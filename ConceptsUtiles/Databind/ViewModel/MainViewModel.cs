using ApplicationDeBase.ViewModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;

namespace Databind.ViewModel
{
    public class MainViewModel : ViewModelBase
    {

        public MainViewModel()
        {
            PersonneExemple = new Personne() { Civilite = CiviliteEnum.Monsieur, Nom = "Bob" };

            ListePersonneExemple.Add(new Personne() { Civilite = CiviliteEnum.Monsieur, Nom = "Nicolas" });
            ListePersonneExemple.Add(new Personne() { Civilite = CiviliteEnum.Madame, Nom = "Elodie" });
            ListePersonneExemple.Add(new Personne() { Civilite = CiviliteEnum.Monsieur, Nom = "Lionel" });
            ListePersonneExemple.Add(new Personne() { Civilite = CiviliteEnum.Monsieur, Nom = "Vincent" });
        }

        #region DonneeExemple
        private string _DonneeExemple = "Exemple de donnée modifiée";

        /// <summary>
        /// Sets and gets the DonneeExemple property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string DonneeExemple
        {
            get
            {
                return _DonneeExemple;
            }

            set
            {
                if (_DonneeExemple == value)
                {
                    return;
                }

                _DonneeExemple = value;
                RaisePropertyChanged("DonneeExemple");
            }
        }
        #endregion

        #region PersonneExemple
        private Personne _PersonneExemple = null;

        /// <summary>
        /// Sets and gets the PersonneExemple property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public Personne PersonneExemple
        {
            get
            {
                return _PersonneExemple;
            }

            set
            {
                if (_PersonneExemple == value)
                {
                    return;
                }

                _PersonneExemple = value;
                RaisePropertyChanged("PersonneExemple");
            }
        }
        #endregion

        #region ListePersonneExemple
        private ObservableCollection<Personne> _ListePersonneExemple = new ObservableCollection<Personne>();

        /// <summary>
        /// Sets and gets the ListePersonneExemple property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public ObservableCollection<Personne> ListePersonneExemple
        {
            get
            {
                return _ListePersonneExemple;
            }

            set
            {
                if (_ListePersonneExemple == value)
                {
                    return;
                }

                _ListePersonneExemple = value;
                RaisePropertyChanged("ListePersonneExemple");
            }
        }
        #endregion
    }
}