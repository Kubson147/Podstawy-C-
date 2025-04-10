using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    class Program
    {
        //Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie
        //sumę wczytanych liczb.
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int n;
            Console.WriteLine("Podaj ile elementów w tablicy:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Podaj {0} element tablicy:", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma += tab[i];
            }
            Console.WriteLine("Suma wczytanych liczb wynosi: {0}", suma);
            Console.ReadKey(true);
        }
    }
}
