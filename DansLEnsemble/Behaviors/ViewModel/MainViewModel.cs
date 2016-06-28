using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Behaviors.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {

        }

        #region ValeurAIncrementer
        private int _ValeurAIncrementer = 0;

        public int ValeurAIncrementer
        {
            get
            {
                return _ValeurAIncrementer;
            }

            set
            {
                if (_ValeurAIncrementer == value)
                {
                    return;
                }

                _ValeurAIncrementer = value;
                RaisePropertyChanged("ValeurAIncrementer");
            }
        }
        #endregion

        #region BooleenAInverser
        private bool _BooleenAInverser = false;

        public bool BooleenAInverser
        {
            get
            {
                return _BooleenAInverser;
            }

            set
            {
                if (_BooleenAInverser == value)
                {
                    return;
                }

                _BooleenAInverser = value;
                RaisePropertyChanged("BooleenAInverser");
            }
        }
        #endregion

    }
}