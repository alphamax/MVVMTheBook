using ApplicationForTests.Algorithme;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;

namespace ApplicationForTests.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private AbstractRandomEngine randomEngine;

        public MainViewModel(AbstractRandomEngine parameter)
        {
            randomEngine = parameter;
        }

        #region TableauResultat
        private List<double> _TableauResultat = null;

        /// <summary>
        /// Sets and gets the TableauResultat property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public List<double> TableauResultat
        {
            get
            {
                return _TableauResultat;
            }

            set
            {
                if (_TableauResultat == value)
                {
                    return;
                }

                _TableauResultat = value;
                RaisePropertyChanged("TableauResultat");
            }
        }
        #endregion

        #region NbElement
        private int _NbElement = 3000000;

        /// <summary>
        /// Sets and gets the NbElement property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public int NbElement
        {
            get
            {
                return _NbElement;
            }

            set
            {
                if (_NbElement == value)
                {
                    return;
                }

                _NbElement = value;
                RaisePropertyChanged("NbElement");
            }
        }
        #endregion

        #region CalculCommand
        private RelayCommand<object> _CalculCommand;
        public RelayCommand<object> CalculCommand
        {
            get
            {
                if (_CalculCommand == null)
                    _CalculCommand
                        = new RelayCommand<object>(
                            param => Calcul(param),
                            param => CanCalcul(param));
                return _CalculCommand;
            }
        }

        private bool CanCalcul(object param)
        {
            return true;
        }

        private void Calcul(object param)
        {
            if (CanCalcul(param))
            {
                var array = randomEngine.GenerateArray(NbElement);
                MillisecondesEcoulees = OrderSystem.ReorderArray(ref array, OrderByFlag, SortFlag);
                TableauResultat = array;
            }
        }

        #endregion CalculCommand

        #region MillisecondesEcoulees
        private double _MillisecondesEcoulees = 0;

        /// <summary>
        /// Sets and gets the MillisecondesEcoulees property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public double MillisecondesEcoulees
        {
            get
            {
                return _MillisecondesEcoulees;
            }

            set
            {
                if (_MillisecondesEcoulees == value)
                {
                    return;
                }

                _MillisecondesEcoulees = value;
                RaisePropertyChanged("MillisecondesEcoulees");
            }
        }
        #endregion

        #region SortFlag
        private bool _SortFlag = true;

        /// <summary>
        /// Sets and gets the SortFlag property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public bool SortFlag
        {
            get
            {
                return _SortFlag;
            }

            set
            {
                if (_SortFlag == value)
                {
                    return;
                }

                _SortFlag = value;
                RaisePropertyChanged("SortFlag");
            }
        }
        #endregion

        #region OrderByFlag
        private bool _OrderByFlag = false;

        /// <summary>
        /// Sets and gets the OrderByFlag property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public bool OrderByFlag
        {
            get
            {
                return _OrderByFlag;
            }

            set
            {
                if (_OrderByFlag == value)
                {
                    return;
                }

                _OrderByFlag = value;
                RaisePropertyChanged("OrderByFlag");
            }
        }
        #endregion
    }
}