using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många tal ska slumpas?");
            int antal = int.Parse(Console.ReadLine());
            Random r = new Random();
            for (int i = 0; i < antal; i++)
            {
                Console.Out.WriteLine(r.Next(1, 7));
            }
          
            Console.ReadKey();

        }
    }
}
