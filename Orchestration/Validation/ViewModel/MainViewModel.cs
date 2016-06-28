using GalaSoft.MvvmLight;
using System;
using System.ComponentModel;

namespace Validation.ViewModel
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

                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Le nom est obligatoire");

                _Nom = value;
                RaisePropertyChanged("Nom");
            }
        }
        #endregion

        #region EstMajeur
        private bool _EstMajeur = false;

        /// <summary>
        /// Sets and gets the EstMajeur property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public bool EstMajeur
        {
            get
            {
                return _EstMajeur;
            }

            set
            {
                if (_EstMajeur == value)
                {
                    return;
                }

                if (Age < 18 && value)
                    throw new Exception("Votre age est inférieur à 18 ans. Vous ne pouvez être majeur.");

                _EstMajeur = value;
                RaisePropertyChanged("EstMajeur");
            }
        }
        #endregion

        #region Age
        private int _Age = 18;

        public int Age
        {
            get
            {
                return _Age;
            }

            set
            {
                if (_Age == value)
                {
                    return;
                }

                if (value < 0)
                    throw new Exception("L'age doit être supérieur à 0");

                if (value < 18 && EstMajeur)
                    throw new Exception("Vous êtes marqué comme majeur, votre age ne peut être inférieur à 18 ans.");

                _Age = value;
                RaisePropertyChanged("Age");
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

                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Le prénom est obligatoire");

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

                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("L'adresse est obligatoire");

                _Adresse = value;
                RaisePropertyChanged("Adresse");
            }
        }
        #endregion
    }
}