using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUnkcje_2
{
    class Program
    {
        static int maks(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Test funkcji: {0}", maks(1, 2));
            Console.ReadKey(true);
        }
    }
}
