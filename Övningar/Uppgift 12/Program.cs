using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_12
{
    class Program
    {

        public static double potens(int bas, int exponent)
        {
            double o = Math.Pow(bas, exponent);
            return o;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bas?");
            int bas = int.Parse(Console.ReadLine());
            Console.WriteLine("Exponent?");
            int exponent = int.Parse(Console.ReadLine());
            Console.WriteLine("Svar: " + (potens(bas, exponent)));
            Console.ReadKey();
        }
    }
}
