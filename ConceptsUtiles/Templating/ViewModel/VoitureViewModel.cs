using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Templating.ViewModel
{
    class VoitureViewModel : VehiculeViewModel
    {
        #region Immatriculation
        private string _Immatriculation = string.Empty;

        /// <summary>
        /// Sets and gets the Immatriculation property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string Immatriculation
        {
            get
            {
                return _Immatriculation;
            }

            set
            {
                if (_Immatriculation == value)
                {
                    return;
                }

                _Immatriculation = value;
                RaisePropertyChanged("Immatriculation");
            }
        }
        #endregion
    }
}
