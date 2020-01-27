using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal");
            int tal = int.Parse(Console.ReadLine());
            int räknare = 0;
            for (int i = 0; i < tal; i++)
            {
                räknare++;
                Console.WriteLine(räknare);
            }

          
            Console.ReadKey();
        }
    }
}
