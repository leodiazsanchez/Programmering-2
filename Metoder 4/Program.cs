using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_4
{
    class Program
    {
        static bool ärSiffra(char tecken)
        {
            try
            {
                double siffra = double.Parse(tecken.ToString());
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Mata in ett tecken");
            char tecken = char.Parse(Console.ReadLine());

            if (ärSiffra(tecken) == false){
                Console.WriteLine("Tecknet är inte en siffra");

            } else{
                Console.WriteLine("Tecknet är en siffra");
            }

            Console.ReadKey();

        }
    }
}
