using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace ApplicationDeBase.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {

        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
            }
            else
            {
                // Code runs "for real"
            }
        }

        #region AffichageRectangle
        private bool _AffichageRectangle = false;

        /// <summary>
        /// Sets and gets the AffichageRectangle property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public bool AffichageRectangle
        {
            get
            {
                return _AffichageRectangle;
            }

            set
            {
                if (_AffichageRectangle == value)
                {
                    return;
                }

                _AffichageRectangle = value;
                RaisePropertyChanged(() => this.AffichageRectangle);
            }
        }
        #endregion

        #region CacherRectangleCommand
        private RelayCommand<object> _CacherRectangleCommand;
        public RelayCommand<object> CacherRectangleCommand
        {
            get
            {
                if (_CacherRectangleCommand == null)
                    _CacherRectangleCommand
                        = new RelayCommand<object>(
                            param => CacherRectangle(param),
                            param => CanCacherRectangle(param));
                return _CacherRectangleCommand;
            }
        }

        private bool CanCacherRectangle(object param)
        {
            return true;
        }

        private void CacherRectangle(object param)
        {
            if (CanCacherRectangle(param))
            {

            }
        }

        #endregion CacherRectangleCommand
    }
}