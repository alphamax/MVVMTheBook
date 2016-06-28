using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallelisme.Data
{
    public class Prevision
    {
        public Prevision(double temperature, double tauxHumidite, double vitesseVent)
        {
            Temparature = temperature;
            TauxHumidite = tauxHumidite;
            VitesseVent = vitesseVent;

        }

        public double Temparature { get; private set; }
        public double TauxHumidite { get; private set; }
        public double VitesseVent { get; private set; }
    }
}
