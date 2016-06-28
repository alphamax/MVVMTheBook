using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriRoleBased.ViewModel
{
    public class SearchViewModel : ViewModelBase
    {
        private List<string> TousLesNoms;
        private string ChampRecherche;

        public void MiseAJour(List<string> tousLesNoms, string champRecherche)
        {
            TousLesNoms = tousLesNoms;
            ChampRecherche = champRecherche;
            RaisePropertyChanged("TousLesNomsFiltres");
        }

        #region TousLesNomsFiltres
        public List<string> TousLesNomsFiltres
        {
            get
            {
                if (TousLesNoms != null)
                {
                    return TousLesNoms.Where(c => c.Contains(ChampRecherche)).ToList();
                }
                else
                {
                    return null;
                }
            }
        }
        #endregion
    }
}
