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
            var pathFolder = @"C:\Users\huynh\OneDrive";
            var newList = FilterFile(pathFolder, x =>x.EndsWith(".txt"));

            newList.ForEach(Console.WriteLine);

            Console.ReadKey();
        }

        public static List<string> FilterFile(string path, Predicate<string> filter)
        {
            var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

            var list = new List<string>();

            foreach (var file in files)
            {
                if (filter(file))
                {
                    list.Add(file);
                }
            }

            return list;
        }
    }
}
