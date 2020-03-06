using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism_Exempel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figur> minafigurer = new List<Figur>();

            Cirkel cirkel = new Cirkel("Blå", 3);
            Rektangel rektangel = new Rektangel("Röd", 4,2);
            Triangel triangel = new Triangel("Grön", 3, 2);
            Ellips ellips = new Ellips(3, 2);

            minafigurer.Add(cirkel);
            minafigurer.Add(rektangel);
            minafigurer.Add(triangel);
            minafigurer.Add(ellips);

            double areatot = 0;
            foreach(Figur f in minafigurer)
            {
                areatot += f.BeräknaArea();
            }

            Console.WriteLine("Total Area: " + areatot.ToString());

            Console.ReadKey();
        }
    }
}
