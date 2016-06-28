using GalaSoft.MvvmLight;
using ModelFirst.Helper;
using System.Collections.Generic;
using System.Linq;

namespace TriRoleBased.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            for (int i = 0; i < 1000; i++)
            {
                TousLesNoms.Add(GenerateurNom.GenererNom());
            }
            SearchEngine.MiseAJour(TousLesNoms, "");
        }

        public List<string> TousLesNoms = new List<string>();

        #region ChampRecherche
        private string _ChampRecherche = string.Empty;

        public string ChampRecherche
        {
            get
            {
                return _ChampRecherche;
            }

            set
            {
                if (_ChampRecherche == value)
                {
                    return;
                }

                _ChampRecherche = value;
                RaisePropertyChanged("ChampRecherche");
                SearchEngine.MiseAJour(TousLesNoms, value);
            }
        }
        #endregion

        #region SearchEngine
        private SearchViewModel _SearchEngine = new SearchViewModel();

        public SearchViewModel SearchEngine
        {
            get
            {
                return _SearchEngine;
            }

            set
            {
                if (_SearchEngine == value)
                {
                    return;
                }

                _SearchEngine = value;
                RaisePropertyChanged("SearchEngine");
            }
        }
        #endregion
    }
}