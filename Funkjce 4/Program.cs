using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkjce_4
{
    class Program
    {
        static int ile_cyfr(int n)
        {
            int i = 0;
            while (n > 0)
            {
                n /= 10;
                i++;
            }
            return i;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Test funkcji: {0}", ile_cyfr(123456));
            Console.ReadKey(true);
        }
    }
}
