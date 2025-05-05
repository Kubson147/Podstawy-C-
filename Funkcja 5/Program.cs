using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcja_5
{
    class Program
    {
        static int funkcja(int a)
        {
            int i;
            for(i = 2; i <= a / 2; i++)
            {
                if(a % i == 0)
                {
                    return 1;
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Liczba 13 jest liczbą pierwszą? {0}", funkcja(13));
        }
    }
}
