using ApplicationDeBase.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databind.ViewModel
{
    public class Personne
    {
        public string Nom { get; set; }

        public CiviliteEnum Civilite { get; set; }
    }
}
