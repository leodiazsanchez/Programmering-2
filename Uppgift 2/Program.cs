using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriv ett program som beräknar cirkelns area

            Console.WriteLine("Cirkelns raide?:");
            double radie = double.Parse(Console.ReadLine());
            double area = Math.Pow(radie,2) * Math.PI;
            Console.WriteLine("Cirkelns area är: " + Math.Round(area));

            //Avsluta
            Console.ReadKey();
        }
    }
}
