using GalaSoft.MvvmLight;
using ModelFirst.Helper;
using System.Collections.Generic;
using System.Linq;

namespace Tri.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            for (int i = 0; i < 1000; i++)
            {
                TousLesNoms.Add(GenerateurNom.GenererNom());
            }
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
                RaisePropertyChanged("TousLesNomsFiltres");
            }
        }
        #endregion

        #region TousLesNomsFiltres
        public List<string> TousLesNomsFiltres
        {
            get
            {
                return TousLesNoms.Where(c => c.Contains(ChampRecherche)).ToList();
            }
        }
        #endregion
    }
}