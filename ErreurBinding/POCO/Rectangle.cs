using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErreurBinding.POCO
{
    class Rectangle : ViewModelBase
    {
        public string Type
        {
            get
            {
                return GetType().Name;
            }
        }

        public double Surface
        {
            get
            {
                return Longueur * Longueur;
            }
        }

        private double _Longueur = 0;
        public double Longueur
        {
            get
            {
                return _Longueur;
            }

            set
            {
                _Longueur = value;
                RaisePropertyChanged("Longueur");
                RaisePropertyChanged("Surface");
            }
        }

        private double _Largeur = 0;
        public double Largeur
        {
            get
            {
                return _Largeur;
            }

            set
            {
                _Largeur = value;
                RaisePropertyChanged("Largeur");
                RaisePropertyChanged("Surface");
            }
        }
    }
}
