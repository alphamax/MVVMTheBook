using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessIntelligence.ViewModel
{
    public class Note
    {
        public int Valeur { get; set; }
        public string Academie { get; set; }

        public override string ToString()
        {
            return Valeur.ToString("00") + "/20 " + Academie;
        }
    }
}
