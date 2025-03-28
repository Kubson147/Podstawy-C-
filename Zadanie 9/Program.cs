using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int i;
            int n;
            Console.WriteLine("Podaj ile elementów tablicy:");
            n = Convert.ToInt32(Console.ReadLine());
            for(i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj {0} element tablicy:", tab[i]);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }    
            for (i = n-1; i >= 0; i--)
            {
                Console.WriteLine(tab[i]);
            }
            Console.ReadKey(true);
        }
    }
}
