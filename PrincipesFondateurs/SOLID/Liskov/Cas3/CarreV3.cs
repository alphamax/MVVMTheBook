using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov.Cas1
{
    public class CarreV3 : GeometrieV3
    {
        public float LongueurCote { get; set; }

        public override float Perimetre { get { return 4 * (LongueurCote); } }
        public override float Aire { get { return LongueurCote * LongueurCote; } }
    }
}
