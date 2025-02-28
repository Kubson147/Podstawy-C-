using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby całkowite i wypisujący na ekranie iloraz tych liczb z
            //uwzględnieniem części całkowitej i reszty z dzielenia.
            int a;
            int b;
            int iloraz;
            double reszta;
            Console.WriteLine("podaj liczbę a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj liczbę b:");
            b = Convert.ToInt32(Console.ReadLine());
            iloraz = a / b;
            reszta = a % b;
            Console.WriteLine("Wynik dzielenia: {0}, Reszta: {1}", iloraz, reszta);
            Console.ReadKey();
        }
    }
}
