using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_exempel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bas?");
            double bas = double.Parse(Console.ReadLine());
            Console.WriteLine("Höjd?");
            double höjd = double.Parse(Console.ReadLine());
            double area;
            double omkrets;
            beräkning(bas, höjd, out area, out omkrets);
            Console.WriteLine("Area: " + area  +  " Omkrets: " + omkrets);
            Console.ReadKey();
        }

        // def en metod som returnerar både area och omkrets för en rekt.

        static void beräkning(double b, double h, out double area, out double omkrets)
        {
            area = b * h;
            omkrets = 2 * b + 2 * h;
        }
    }
}
