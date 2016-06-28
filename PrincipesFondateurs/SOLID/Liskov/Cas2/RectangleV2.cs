using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov.Cas1
{
    public class RectangleV2 : CarreV2
    {
        public float Largeur { get; set; }

        public override float Perimetre { get { return 2 * (LongueurCote + Largeur); } }
        public override float Aire { get { return LongueurCote * Largeur; } }
    }
}
