using GalaSoft.MvvmLight;

namespace MultiVue.ViewModel
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
        }

        #region Nom
        private string _Nom = "Duran";

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

        #region Prenom
        private string _Prenom = "Pierre";

        /// <summary>
        /// Sets and gets the Prenom property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string Prenom
        {
            get
            {
                return _Prenom;
            }

            set
            {
                if (_Prenom == value)
                {
                    return;
                }

                _Prenom = value;
                RaisePropertyChanged("Prenom");
            }
        }
        #endregion

        #region Adresse
        private string _Adresse = "12 rue de l'Etoile";

        /// <summary>
        /// Sets and gets the Adresse property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string Adresse
        {
            get
            {
                return _Adresse;
            }

            set
            {
                if (_Adresse == value)
                {
                    return;
                }

                _Adresse = value;
                RaisePropertyChanged("Adresse");
            }
        }
        #endregion
    }
}