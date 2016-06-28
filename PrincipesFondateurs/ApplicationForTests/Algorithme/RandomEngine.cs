using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForTests.Algorithme
{
    public class RandomEngine : AbstractRandomEngine
    {
        int NbCall = DateTime.Now.Millisecond;
        public override double GenerateNextDouble()
        {
            double result = Math.Sin(((double)NbCall) / 2d) * 10000;
            NbCall++;
            return result;
        }
    }
}
