using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public delegate List<int> ListOfPrimeSmallerX(int i);

    class Program
    {
        static void Main(string[] args)
        {
            ListOfPrimeSmallerX listOfPrimeSmallerX = (x) =>
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

            var newList = listOfPrimeSmallerX(100);

            newList.ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
