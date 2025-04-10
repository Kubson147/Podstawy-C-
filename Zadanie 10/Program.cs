using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int n;
            int sort;
            Console.WriteLine("Podaj ile elementów w tablicy:");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj {0} element tablicy:", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < n; i++)
            {
                for(int j = i+1; j < n; j++) 
                {
                    if (tab[i] > tab[j])
                    {
                        sort = tab[i];
                        tab[i] = tab[j];
                        tab[j] = sort;
                    }
                }
                
            }
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}", tab[i]);
            }
            Console.ReadKey(true);
        }
    }
}
