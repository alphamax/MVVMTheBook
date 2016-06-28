using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForTests.Algorithme
{
    public abstract class AbstractRandomEngine
    {
        public abstract double GenerateNextDouble();

        public List<double> GenerateArray(int nbItem)
        {
            List<double> array = new List<double>();
            for (int i = 0; i < nbItem; i++)
            {
                array.Add(GenerateNextDouble());
            }
            return array;
        }
    }
}
