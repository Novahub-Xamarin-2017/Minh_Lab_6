using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
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
