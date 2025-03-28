using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int i;
            int n;
            Console.WriteLine("podaj ile elementów:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj element {0}:", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0}", tab[i]);
            }
            Console.ReadKey(true);
        }
    }
}
