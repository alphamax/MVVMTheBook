using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SOLID.Interface
{
    interface IModule
    {
        int PourcentageChargement { get;}

        void Initialiser(object etat);
        void SauvegarderConfiguration();
        void ChargerConfiguration();
        void Fermer();

        UserControl PreparerInterface();
        void LancerBouclePrincipale();
    }
}
