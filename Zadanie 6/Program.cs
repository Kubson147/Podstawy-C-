using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn i
            //iloraz.dawdaw
            double a;
            double b;
            double suma;
            double różnica;
            double iloczyn;
            double iloraz;
            Console.WriteLine("podaj liczbę a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj liczbę b:");
            b = Convert.ToDouble(Console.ReadLine());
            suma = a + b;
            różnica = a - b;
            iloczyn = a * b;
            iloraz = a / b;
            Console.WriteLine("suma: {0}, różnica: {1}, iloczyn: {2}, iloraz: {3}", suma, różnica, iloczyn, iloraz);
            Console.ReadKey();
        }
    }
}
