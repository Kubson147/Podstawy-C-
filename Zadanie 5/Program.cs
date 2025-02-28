using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący promień podstawy (r) i wysokość (h) stożka i wypisujący na
            //ekranie objętość i pole całkowite tego stożka.
            double r;
            double h;
            double polep;
            double objetosc;
            double tworzaca;
            double polec;
            Console.WriteLine("podaj promień podstawy:");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj wysokość stożka:");
            h = Convert.ToDouble(Console.ReadLine());
            polep = Math.PI * r * r;
            objetosc = polep * 1 / 3 * h;
            Console.WriteLine("Objętość stożka wynosi:{0}", objetosc);
            tworzaca = Math.Sqrt(h * h + r * r);
            polec = Math.PI * r * tworzaca + polep;
            Console.WriteLine("Pole powierzchni stożka wynosi : {0}", polec);
            Console.ReadKey();
        }
    }
}
