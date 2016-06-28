using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov.Cas1
{
    public class CarreV1 : RectangleV1
    {
        private float _Longueur;
        private float _Largeur;
        public override float Longueur
        {
            get
            {
                return _Longueur;
            }
            set
            {
                _Longueur = value;
                _Largeur = value;
            }
        }
        public override float Largeur
        {
            get
            {
                return _Largeur;
            }
            set
            {
                _Longueur = value;
                _Largeur = value;
            }
        }
    }
}
