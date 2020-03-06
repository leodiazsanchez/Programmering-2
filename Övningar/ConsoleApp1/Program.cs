using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriv ett program som beräknar triangelns area

            Console.WriteLine("Triangelns bas?:");
            double bas = double.Parse(Console.ReadLine());
            Console.WriteLine("Triangelns höjd?:");
            double höjd = double.Parse(Console.ReadLine());
            double area = (bas * höjd) / 2;
            Console.WriteLine("Triangelns area är: " + area);
            //Avsluta
            Console.ReadKey();
        }
    }
}
