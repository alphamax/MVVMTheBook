using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parallelisme.Data
{
    public static class CoucheDonnees
    {
        private static Random RandomEngine;

        static CoucheDonnees()
        {
            RandomEngine = new Random(DateTime.Now.Millisecond);
        }

        public static int GetNbMesure()
        {
            return 6;
        }

        public static Prevision GetMesure(int index)
        {
            //Entre 2 et 7 secondes
            Thread.Sleep(RandomEngine.Next(4000));

            switch (index)
            {
                case 0:
                    return new Prevision(12, 50, 8);
                case 1:
                    return new Prevision(15, 41, 12);
                case 2:
                    return new Prevision(17, 33, 15);
                case 3:
                    return new Prevision(20, 31, 10);
                case 4:
                    return new Prevision(18, 65, 3);
                case 5:
                    return new Prevision(22, 60, 22);
                default:
                    return new Prevision(23, 50, 25);
            }
        }
    }
}
