using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string namn = "Leo";
            skrivut();
            skrivut(namn);
            Console.ReadKey();
        }

        static void skrivut()
        {
            Console.WriteLine("Hej eller nåt");
        }

        static void skrivut(string namn, string namn1 = "Pelle")
        {
            Console.WriteLine("Hej " + namn + " och " + namn1);
        }
    }
}
          