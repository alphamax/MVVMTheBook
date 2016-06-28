using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Templating.ViewModel
{
    public class VehiculeViewModel : ViewModelBase
    {
        #region Nom
        private string _Nom = string.Empty;

        /// <summary>
        /// Sets and gets the Nom property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string Nom
        {
            get
            {
                return _Nom;
            }

            set
            {
                if (_Nom == value)
                {
                    return;
                }

                _Nom = value;
                RaisePropertyChanged("Nom");
            }
        }
        #endregion
    }
}
