using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, Func<string, bool>, List<string>> FilterFile = (path, endWith) =>
            {
                var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

                var list = new List<string>();

                foreach(var i in files)
                {
                    if (endWith(i))
                    {
                        list.Add(i);
                    }
                }

                return list;
            };

            var pathFolder = @"C:\Users\huynh\OneDrive";
            var newList = FilterFile(pathFolder, x =>x.EndsWith(".txt"));
            newList.ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
