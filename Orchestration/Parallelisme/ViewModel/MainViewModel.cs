using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Parallelisme.Data;
using System.Linq;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using System;

namespace Parallelisme.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
        }

        #region Mesures
        private ObservableCollection<Prevision> _Mesures = new ObservableCollection<Prevision>();

        public ObservableCollection<Prevision> Mesures
        {
            get
            {
                return _Mesures;
            }

            set
            {
                if (_Mesures == value)
                {
                    return;
                }

                _Mesures = value;
                RaisePropertyChanged("Mesures");
            }
        }
        #endregion

        #region RecuperationSimpleCommand
        private RelayCommand _RecuperationSimpleCommand;
        public RelayCommand RecuperationSimpleCommand
        {
            get
            {
                if (_RecuperationSimpleCommand == null)
                    _RecuperationSimpleCommand
                        = new RelayCommand(RecuperationSimple);
                return _RecuperationSimpleCommand;
            }
        }

        private void RecuperationSimple()
        {
            Mesures.Clear();
            int nbMesure = CoucheDonnees.GetNbMesure();
            for (int i = 0; i < nbMesure; i++)
            {
                Mesures.Add(CoucheDonnees.GetMesure(i));
            }
        }

        #endregion RecuperationSimpleCommand

        #region RecuperationTPLParallelCommand
        private RelayCommand _RecuperationTPLParallelCommand;
        public RelayCommand RecuperationTPLParallelCommand
        {
            get
            {
                if (_RecuperationTPLParallelCommand == null)
                    _RecuperationTPLParallelCommand
                        = new RelayCommand(RecuperationTPLParallel);
                return _RecuperationTPLParallelCommand;
            }
        }

        private void RecuperationTPLParallel()
        {
            Mesures.Clear();
            int nbMesure = CoucheDonnees.GetNbMesure();
            ConcurrentBag<Prevision> result = new ConcurrentBag<Prevision>();
            Parallel.For(0, nbMesure, (i) =>
                {
                    result.Add(CoucheDonnees.GetMesure(i));
                });

            foreach (var item in result)
            {
                Mesures.Add(item);
            }
        }

        #endregion RecuperationTPLParallelDispatchCommand

        #region RecuperationTPLParallelDispatchCommand
        private RelayCommand _RecuperationTPLParallelDispatchCommand;
        public RelayCommand RecuperationTPLParallelDispatchCommand
        {
            get
            {
                if (_RecuperationTPLParallelDispatchCommand == null)
                    _RecuperationTPLParallelDispatchCommand
                        = new RelayCommand(RecuperationTPLParallelDispatch);
                return _RecuperationTPLParallelDispatchCommand;
            }
        }

        private void RecuperationTPLParallelDispatch()
        {
            Mesures.Clear();
            int nbMesure = CoucheDonnees.GetNbMesure();
            Parallel.For(0, nbMesure, (i) =>
            {
                var mesure = CoucheDonnees.GetMesure(i);
                Application.Current.Dispatcher.BeginInvoke(new Action(() =>
                {
                    Mesures.Add(mesure);
                }));
            });
        }

        #endregion RecuperationTPLParallelDispatchCommand

        #region RecuperationTPLParallelTaskCommand
        private RelayCommand _RecuperationTPLParallelTaskCommand;
        public RelayCommand RecuperationTPLParallelTaskCommand
        {
            get
            {
                if (_RecuperationTPLParallelTaskCommand == null)
                    _RecuperationTPLParallelTaskCommand
                        = new RelayCommand(RecuperationTPLParallelTask);
                return _RecuperationTPLParallelTaskCommand;
            }
        }

        private void RecuperationTPLParallelTask()
        {
            Mesures.Clear();
            int nbMesure = CoucheDonnees.GetNbMesure();

            List<Task> tasks = new List<Task>();

            for (int i = 0; i < nbMesure; i++)
            {
                tasks.Add(new Task((index) =>
                    {
                        var mesure = CoucheDonnees.GetMesure((int)index);
                        Application.Current.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            Mesures.Add(mesure);
                        }));
                    }, i));
            }
            tasks.ForEach(t => t.Start());
        }

        #endregion RecuperationTPLParallelTaskCommand
    }
}