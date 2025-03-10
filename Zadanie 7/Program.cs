using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę arabską od 1 do 3999 i wypisujący na ekranie jej
            //odpowiednik rzymski.
            int a;
            string b = "";
            Console.WriteLine("Podaj liczbę:");
            a = Convert.ToInt32(Console.ReadLine());

            if (a >= 3000)
            { a -= 3000; b = "MMM"; }
            else if (a >= 2000)
            { a -= 2000; b = "MM"; }
            else if (a >= 1000)
            { a -= 1000; b = "M"; }

            if (a >= 900)
            { a -= 900; b = string.Concat(b, "CM"); }
            else if (a >= 800)
            { a -= 800; b = string.Concat(b, "DCCC"); }
            else if (a >= 700)
            { a -= 700; b = string.Concat(b, "DCC"); }
            else if (a >= 600)
            { a -= 600; b = string.Concat(b, "DC"); }
            else if (a >= 500)
            { a -= 500; b = string.Concat(b, "D"); }
            else if (a >= 400)
            { a -= 400; b = string.Concat(b, "CD"); }
            else if (a >= 300)
            { a -= 300; b = string.Concat(b, "CCC"); }
            else if (a >= 200)
            { a -= 200; b = string.Concat(b, "CC"); }
            else if (a >= 100)
            { a -= 100; b = string.Concat(b, "C"); }

            if (a >= 90)
            { a -= 90; b = string.Concat(b, "XC"); }
            else if (a >= 80)
            { a -= 80; b = string.Concat(b, "LXXX"); }
            else if (a >= 70)
            { a -= 70; b = string.Concat(b, "LXX"); }
            else if (a >= 60)
            { a -= 60; b = string.Concat(b, "LX"); }
            else if (a >= 50)
            { a -= 50; b = string.Concat(b, "L"); }
            else if (a >= 40)
            { a -= 40; b = string.Concat(b, "XL"); }
            else if (a >= 30)
            { a -= 30; b = string.Concat(b, "XXX"); }
            else if (a >= 20)
            { a -= 20; b = string.Concat(b, "XX"); }
            else if (a >= 10)
            { a -= 10; b = string.Concat(b, "X"); }

            if (a >= 9)
            { a -= 9; b = string.Concat(b, "IX"); }
            else if (a >= 8)
            { a -= 8; b = string.Concat(b, "VIII"); }
            else if (a >= 7)
            { a -= 7; b = string.Concat(b, "VII"); }
            else if (a >= 60)
            { a -= 6; b = string.Concat(b, "VI"); }
            else if (a >= 5)
            { a -= 5; b = string.Concat(b, "V"); }
            else if (a >= 4)
            { a -= 4; b = string.Concat(b, "IV"); }
            else if (a >= 3)
            { a -= 3; b = string.Concat(b, "III"); }
            else if (a >= 2)
            { a -= 2; b = string.Concat(b, "II"); }
            else if (a >= 1)
            { a -= 1; b = string.Concat(b, "I"); }

            Console.WriteLine(b);

            Console.ReadKey(true);

        }
    }
}
