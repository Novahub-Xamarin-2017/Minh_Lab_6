using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    class Program
    {
        private static double Sum(double n, Func<double, double> method)
        {
            var sum = 0.0;

            for (int i = 1; i <= n; i++)
            {
                sum = sum + method(i);
            }

            return sum;
        }

        static void Main(string[] args)
        {
            var n = 3;

            Console.WriteLine(Sum(n, x => Math.Pow(x, x)));
            Console.WriteLine(Sum(n, x => x * (x + 1)));

            Console.ReadKey();
        }
    }
}
