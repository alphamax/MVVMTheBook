using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov.Cas1
{
    public class RectangleV1
    {
        public virtual float Longueur { get; set; }
        public virtual float Largeur { get; set; }

        public float Perimetre { get { return 2 * (Longueur + Largeur); } }
        public float Aire { get { return Longueur * Largeur; } }
    }
}
