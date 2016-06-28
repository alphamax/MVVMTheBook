using DansLEnsemble.Messages;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace DansLEnsemble.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {

        }

        #region ShowInfo
        private bool _ShowInfo = false;

        public bool ShowInfo
        {
            get
            {
                return _ShowInfo;
            }

            set
            {
                if (_ShowInfo == value)
                {
                    return;
                }

                _ShowInfo = value;
                RaisePropertyChanged("ShowPopup");
                RaisePropertyChanged("ShowInfo");
            }
        }
        #endregion

        #region Info
        private string _Info = string.Empty;

        public string Info
        {
            get
            {
                return _Info;
            }

            set
            {
                if (_Info == value)
                {
                    return;
                }

                _Info = value;
                RaisePropertyChanged("Info");
            }
        }
        #endregion

        #region PopupInfoCommand
        private RelayCommand<object> _PopupInfoCommand;
        public RelayCommand<object> PopupInfoCommand
        {
            get
            {
                if (_PopupInfoCommand == null)
                    _PopupInfoCommand
                        = new RelayCommand<object>(
                            param => PopupInfo(param),
                            param => CanPopupInfo(param));
                return _PopupInfoCommand;
            }
        }

        private bool CanPopupInfo(object param)
        {
            return true;
        }

        private void PopupInfo(object param)
        {
            if (CanPopupInfo(param))
            {
                Info = "Ceci est un message informatif, dicté dans le commande";
                ShowInfo = true;
            }
        }

        #endregion PopupInfoCommand

    }
}