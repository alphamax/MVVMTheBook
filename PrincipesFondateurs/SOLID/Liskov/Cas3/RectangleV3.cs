using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov.Cas1
{
    public class RectangleV3 : GeometrieV3
    {
        public float Longueur { get; set; }
        public float Largeur { get; set; }

        public override float Perimetre { get { return 2 * (Longueur + Largeur); } }
        public override float Aire { get { return Longueur * Largeur; } }
    }
}
