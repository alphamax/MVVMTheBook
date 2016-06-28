using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GlassPane.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
        }

        #region LancerCommand
        private RelayCommand _LancerCommand;
        public RelayCommand LancerCommand
        {
            get
            {
                if (_LancerCommand == null)
                    _LancerCommand
                        = new RelayCommand(
                            () => Lancer());
                return _LancerCommand;
            }
        }

        private void Lancer()
        {
            AjouterChargement();
        }

        #endregion LancerCommand

        #region StopperCommand
        private RelayCommand _StopperCommand;
        public RelayCommand StopperCommand
        {
            get
            {
                if (_StopperCommand == null)
                    _StopperCommand
                        = new RelayCommand(
                            () => Stopper());
                return _StopperCommand;
            }
        }

        private void Stopper()
        {
            EnleverChargement();
        }

        #endregion StopperCommand

        #region LancerMultipleCommand
        private RelayCommand _LancerMultipleCommand;
        public RelayCommand LancerMultipleCommand
        {
            get
            {
                if (_LancerMultipleCommand == null)
                    _LancerMultipleCommand
                        = new RelayCommand(
                            () => LancerMultiple());
                return _LancerMultipleCommand;
            }
        }

        private void LancerMultiple()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            List<Task> tasks = new List<Task>();
            for (int i = 0; i < 20; i++)
            {
                tasks.Add(new Task(() =>
                    {
                        AjouterChargement();
                        Thread.Sleep(r.Next(2000));
                        EnleverChargement();
                    }));
            }
            tasks.ForEach(c => c.Start());
        }

        #endregion LancerMultipleCommand

       #region EnChargement
        public bool EnChargement
       {
           get
           {
               return EstEnChargementCompteur > 0;
           }
       }
       #endregion

       private int EstEnChargementCompteur;

       private void AjouterChargement()
       {
           Interlocked.Increment(ref EstEnChargementCompteur);
           RaisePropertyChanged("EnChargement");
       }

       private void EnleverChargement()
       {
           Interlocked.Decrement(ref EstEnChargementCompteur);
           RaisePropertyChanged("EnChargement");
       }

       
    }
}