using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov.Cas1
{
    public class CarreV2
    {
        public float LongueurCote { get; set; }

        public virtual float Perimetre { get { return 4 * (LongueurCote); } }
        public virtual float Aire { get { return LongueurCote * LongueurCote; } }
    }
}
