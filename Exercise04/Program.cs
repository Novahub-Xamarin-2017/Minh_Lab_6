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

        public static List<string> FilterFile(string path, Func<string, bool> endWith)
        {
            var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

            var list = new List<string>();

            foreach (var i in files)
            {
                if (endWith(i))
                {
                    list.Add(i);
                }
            }

            return list;
        }
    }
}
