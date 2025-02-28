using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double pole;
            double obwod;
            Console.WriteLine("podaj bok a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj bok b");
            b = Convert.ToDouble(Console.ReadLine());
            pole = a * b;
            obwod = a + a + b + b;
            Console.WriteLine("pole wynosi {0}", pole);
            Console.WriteLine("obwod wynosi {0}", obwod);
            Console.ReadKey();
        }
    }
}
