using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForTests.Algorithme
{
    public class OrderSystem
    {
        public static double ReorderArray(ref List<double> array, bool orderByFlag, bool sortFlag)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            if (sortFlag)
                array.Sort();
            else if (orderByFlag)
                array = array.OrderBy(c => c).ToList();

            sw.Stop();
            return sw.ElapsedMilliseconds;
        }

    }
}
