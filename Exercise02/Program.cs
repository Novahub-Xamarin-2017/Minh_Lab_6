using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, Func<int, bool>, List<int>> ListOfNumber = (x, method) =>
              {
                  var list = new List<int>();

                  for (int i = 1; i <= x - 1; i++)
                  {
                      if (method(i))
                      {
                          list.Add(i);
                      }
                  }

                  return list;
              };

            var newList = ListOfNumber(100, x => x % 2 == 0);

            newList.ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
