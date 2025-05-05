using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje_3
{
    class Program
    {
        static double pole(double r)
        {
            return Math.PI * r * r;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Test funkcji: {0}", pole(2));
            Console.ReadKey(true);
        }
    }
}
