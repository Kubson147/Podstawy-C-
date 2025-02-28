using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej
            //największej z tych liczb.
            int a;
            int b;
            int c;
            int d;
            int e;
            int max;
            int min;

            Console.WriteLine("Podaj liczbę 1:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę 2:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę 3:");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę 4:");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę 5:");
            e = Convert.ToInt32(Console.ReadLine());

            min = a;
            max = a;

            if (b < min)
            { min = b; }
            if (c < min)
            { min = c; }
            if (d < min)
            { min = d; }
            if (e < min) 
            { min = e; }

            if (b > max)
            { max = b; }
            if (c > max) 
            { max = c; }
            if (d > max)
            { max = d; }
            if (e > max)
            { max = e; }

            Console.WriteLine("Największa liczba wynosi: {0} a najmniejsza liczba wynosi: {1}", max, min);
            Console.ReadKey(true);

        }
    }
}
