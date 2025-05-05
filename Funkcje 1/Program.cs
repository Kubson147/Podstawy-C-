using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje_1
{
    class Program
    {
        static int suma (int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Test funkcji: {0}", suma(2, 3));
            Console.ReadKey(true);
        }
    }
}
