using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Struktury_2
{
    class Program
    {
        struct Uczen
        {
            public string imie, nazwisko;
            public byte[] oceny; 
        }
        static void Main(string[] args)
        {
            Uczen[] uczniowie;
            int liczbaUczniow;
            int liczbaOcen;
            int i;
            int j;
            Console.WriteLine("Podaj ile jest uczniów w klasie:");
            liczbaUczniow = Convert.ToInt32(Console.ReadLine());
            uczniowie = new Uczen[liczbaUczniow];
            for(i = 0; i < liczbaUczniow; i++) 
            {
                Console.WriteLine("Podaj imię ucznia {0}", i+1);
                uczniowie[i].imie = Console.ReadLine();
                Console.WriteLine("Podaj nazwisko ucznia {0}", i+1);
                uczniowie[i].nazwisko = Console.ReadLine();
                Console.WriteLine("Podaj liczbę ocen ucznia {0}", i+1);
                liczbaOcen = Convert.ToInt32(Console.ReadLine());
                uczniowie[i].oceny = new byte[liczbaOcen];
                for(j = 0; j < liczbaOcen; j++)
                {
                    Console.WriteLine("Podaj {0} ocenę ucznia {1}", j+1, i+1);
                    uczniowie[i].oceny[j] = Convert.ToByte(Console.ReadLine());
                }
            }
            for(i = 0; i < liczbaUczniow; i++)
            {
                Console.WriteLine("{0} {1}", uczniowie[i].imie, uczniowie[i].nazwisko);
                foreach(byte o in uczniowie[i].oceny)
                    Console.WriteLine("{0}, ", o);
            }
            Console.ReadKey(true);
        }
    }
}
