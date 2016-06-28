using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstModel.Models
{
    public class Temperature
    {
        public double Valeur { get; set; }
        public DateTime DateDePrise { get; set; }

        public override string ToString()
        {
            return DateDePrise.ToShortDateString() + " - " + Valeur.ToString("N1") + "°c";
        }
    }
}
