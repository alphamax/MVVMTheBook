using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SOLID.Interface
{
    class Module
    {
        public int PourcentageChargement { get; set; }

        public void Initialiser(object etat)
        {
        }
        public void SauvegarderConfiguration()
        {
        }
        public void ChargerConfiguration()
        {
        }
        public void Fermer()
        {
        }

        public UserControl PreparerInterface()
        {
            return null;
        }
        public void LancerBouclePrincipale()
        {
        }
    }
}
