using GalaSoft.MvvmLight;

namespace MessagingTest.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
        }

        #region StatusBarViewModel
        private StatusBarViewModel _StatusBarViewModel = new StatusBarViewModel();

        /// <summary>
        /// Sets and gets the StatusBarViewModel property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public StatusBarViewModel StatusBarViewModel
        {
            get
            {
                return _StatusBarViewModel;
            }

            set
            {
                if (_StatusBarViewModel == value)
                {
                    return;
                }

                _StatusBarViewModel = value;
                RaisePropertyChanged("StatusBarViewModel");
            }
        }
        #endregion

        #region ToolbarViewModel
        private ToolbarViewModel _ToolbarViewModel = new ToolbarViewModel();

        /// <summary>
        /// Sets and gets the ToolbarViewModel property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public ToolbarViewModel ToolbarViewModel
        {
            get
            {
                return _ToolbarViewModel;
            }

            set
            {
                if (_ToolbarViewModel == value)
                {
                    return;
                }

                _ToolbarViewModel = value;
                RaisePropertyChanged("ToolbarViewModel");
            }
        }
        #endregion
    }
}