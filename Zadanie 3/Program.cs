using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i
            //największej z tych liczb.
            int a;
            int b;
            int c;
            int max;
            int min;

            Console.WriteLine("podaj liczbę 1:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj liczbę 2:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj liczbę 3:");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c) 
                { max = a; }
            else if (b > a && b > c)
                { max = b; }
            else { max = c; }

            if (a < b && a < c)
                { min = a; }
            else if (b < a && b < c)
                { min = b; }
            else { min = c; }

            Console.WriteLine("Największa liczba wynosi: {0} a najmniejsza: {1}", max, min);
            Console.ReadKey(true);
        }
    }
}
