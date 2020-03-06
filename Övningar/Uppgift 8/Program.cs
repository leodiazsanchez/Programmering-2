using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nummer på veckodag");
            int dag = int.Parse(Console.ReadLine());
            switch (dag)
            {
                case 1:
                    Console.WriteLine("Måndag");
                    break;
                case 2:
                    Console.WriteLine("Tisdag");
                    break;
                case 3:
                    Console.WriteLine("Onsdag");
                    break;
                case 4:
                    Console.WriteLine("Torsdag");
                    break;
                case 5:
                    Console.WriteLine("Fredag");
                    break;
                case 6:
                    Console.WriteLine("Lördag");
                    break;
                case 7:
                    Console.WriteLine("Söndag");
                    break;
                default:
                    Console.WriteLine("Okänt");
                    break;
            }
            Console.ReadKey();
        }
    }
}
