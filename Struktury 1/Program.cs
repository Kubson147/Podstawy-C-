using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struktury_1
{
    class Program
    {
        struct Osoba 
        {
            public string nazwisko, imie;
            public int rok;
        }
        static void Main(string[] args)
        {
            Osoba o;
            Console.WriteLine("Podaj imie:");
            o.imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko:");
            o.nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj rok urodzenia:");
            o.rok = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {1} urodził się w roku {2}", o.imie, o.nazwisko, o.rok);
            Console.ReadKey(true);
        }
    }
}
