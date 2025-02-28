using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą i wypisujący na ekranie informację czy jest to
            //liczba parzysta, czy też nieparzysta.
            int liczba;
            Console.WriteLine("Podaj liczbę:");
            liczba = Convert.ToInt32(Console.ReadLine());
            if (liczba % 2 == 0 )
                { Console.WriteLine("Liczba jest parzysta");}
            else 
                { Console.WriteLine("liczba jest nieparzysta");};
            Console.ReadKey(true);
        }
    }
}
