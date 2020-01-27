using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ålder?");
            double ålder = double.Parse(Console.ReadLine());

            if (ålder <= 65 && ålder >= 15){
                Console.WriteLine("Pris: 30kr");
            } else
            {
                Console.WriteLine("Pris: 15kr");
            }
            Console.ReadKey();
        }
    }
}
