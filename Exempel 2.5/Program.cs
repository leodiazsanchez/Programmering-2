using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempel_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Samling<string> nysamling = new Samling<string>();
            nysamling.LäggTill("A");
            nysamling.LäggTill("Ö");
            nysamling.LäggTill("F");
            nysamling.LäggTill("Z");
            nysamling.LäggTill("G");
            nysamling.Sortera();


            Console.WriteLine(nysamling.ToString());

            Console.ReadKey();


        }
    }
}
