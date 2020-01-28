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
            nysamling.LäggTill("Hejsan");
            nysamling.LäggTill("Hejdå");
            nysamling.LäggTill("Programmering är kul");
            nysamling.Tabort(1);

            Console.WriteLine(nysamling.ElementFrån(1));

            Console.ReadKey();


        }
    }
}
