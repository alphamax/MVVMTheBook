using GalaSoft.MvvmLight;

namespace ErreurBinding.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            VuePrincipale = new Personne();
        }

        #region VuePrincipale
        private object _VuePrincipale = null;

        public object VuePrincipale
        {
            get
            {
                return _VuePrincipale;
            }

            set
            {
                if (_VuePrincipale == value)
                {
                    return;
                }

                _VuePrincipale = value;
                RaisePropertyChanged("VuePrincipale");
            }
        }
        #endregion
    }
}