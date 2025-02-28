using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest
            //dodatnia, ujemna, czy też równa zero.
            int liczba;
            Console.WriteLine("Podaj liczbę:");
            liczba = Convert.ToInt32(Console.ReadLine());
            if (liczba > 0) { Console.WriteLine("Liczba jest dodatnia."); }
            else if (liczba < 0) { Console.WriteLine("Liczba jest ujemna."); }
            else { Console.WriteLine("Liczba jest równa 0"); };
            Console.ReadKey(true);
        }
    }
}
