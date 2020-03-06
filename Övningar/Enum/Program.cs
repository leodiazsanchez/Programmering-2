using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        enum Storlek {Small,Medium,Large,ExtraLarge};

        static void Main(string[] args)
        {
            Console.WriteLine("Storlek (small=0)?");
            int storlek = int.Parse(Console.ReadLine());
            Storlek storleken = (Storlek)storlek;
            switch (storleken)
            {
                case Storlek.Small:
                    Console.WriteLine("Du valde small");
                    break;
                case Storlek.Medium:
                    Console.WriteLine("Du valde medium");
                    break;
                default:
                    Console.WriteLine("Fel");
                    break;
                
                
                

            }

            Console.WriteLine((int)Storlek.Medium);
            Console.ReadKey();
        }
    }
}
