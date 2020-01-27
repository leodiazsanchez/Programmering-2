using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tecken");
            char tecken = char.Parse(Console.ReadLine());
            int kod = tecken;
            //Console.WriteLine((int)tecken);
            //Console.WriteLine("Tecken {0} har koden {1}",tecken,kod);
            Console.WriteLine($"Tecken {tecken} har koden {kod}");
            Console.ReadKey();

        }
    }
}
