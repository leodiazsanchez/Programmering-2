using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett namn");
            string namn = Console.ReadLine();
            char initial = namn[0];
            char sista = namn[namn.Length - 1];
            Console.WriteLine("Initial: " + initial);
            Console.WriteLine("Sista bokstaven: " + sista);
            Console.ReadKey();
        }
    }
}
