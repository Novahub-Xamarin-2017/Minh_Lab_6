using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, List<int>> ListOfPrimeSmallerX = (x) =>
            {
                var list = new List<int>();

                for (int i = 2; i <= x - 1; i++)
                {
                    if (i.IsPrime())
                    {
                        list.Add(i);
                    }
                }

                return list;
            };

            var newList = ListOfPrimeSmallerX(100);

            newList.ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }

    public static class Extention
    {
        public static bool IsPrime(this int x)
        {
            var n = Math.Sqrt(x);

            for (int i = 2; i <= n; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
