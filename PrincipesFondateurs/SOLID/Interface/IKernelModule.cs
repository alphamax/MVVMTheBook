using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SOLID.Interface
{
    interface IKernelModule
    {
        int PourcentageChargement { get;}
        void Initialiser(object etat);
        void Fermer();
    }
}
