using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_11
{
    class Program
    {
        public static string metod(string versal)
        {
            string o = versal.ToUpper();
            return o;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en gemnen");
            string l = Console.ReadLine();

            Console.WriteLine(metod(l));
            Console.ReadKey();
            
        }

       
    }
}
