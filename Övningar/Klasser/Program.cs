using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Kalle",12);
            Hund hund1 = new Hund("Lucas", 12, "Pudel");
            hund1.Ålder = 15;
            person1.Namn = "Pelle";
            person1.Ålder = 13;
            Console.WriteLine(person1.skrivUt());
            Console.WriteLine(hund1.skrivUt());
            Console.ReadKey();

        }
    }
}
