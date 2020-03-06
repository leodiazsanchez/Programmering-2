using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_6
{
    class Program
    {
        static bool CanJoyride(int age, int cm, bool hasHeartCondition)
        {
            if (age < 12 || cm < 149 || cm > 209 || hasHeartCondition == true) return false;
            else if (cm < 129) return false;
            else return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ålder?");
            int ålder = int.Parse(Console.ReadLine());
            Console.WriteLine("Längd i cm?");
            int längd = int.Parse(Console.ReadLine());
            Console.WriteLine("Har du hjärtproblem? Ja = true Nej = false");
            bool hjärta = bool.Parse(Console.ReadLine());
            Console.WriteLine("Får åka:" + (CanJoyride(ålder, längd, hjärta)));
            Console.ReadKey();
        }
    }
}
