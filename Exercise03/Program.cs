using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, Func<double, double>, double> Sum = (x, method) =>
            {
                var sum = 0.0;

                for (int i = 1; i <= x; i++)
                {
                    sum = sum + method(i);
                }

                return sum;
            };

            var n = 3;

            Console.WriteLine(Sum(n, x => Math.Pow(x, x)));
            Console.WriteLine(Sum(n, x => x * (x + 1)));

            Console.ReadKey();
        }
    }
}
