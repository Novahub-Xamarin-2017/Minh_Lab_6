using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    class Program
    {
        private static List<int> GetAllPrimeNumbersSmallerThan(int x)
        {
            var list = new List<int>();

            for (int i = 2; i < x; i++)
            {
                if (i.IsPrime())
                {
                    list.Add(i);
                }
            }

            return list;
        }

        static void Main(string[] args)
        {
            var newList = GetAllPrimeNumbersSmallerThan(100);

            newList.ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
