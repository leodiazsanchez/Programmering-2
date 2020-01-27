using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal");
            double tal = double.Parse(Console.ReadLine());
            if (tal < 0){
                Console.WriteLine("Talet är negativt");
            } else if (tal > 0)
            {
                Console.WriteLine("Talet är postivt");
            } else
            {
                Console.WriteLine("Talet är 0");
            }
            Console.ReadKey();
        }
    }
}
