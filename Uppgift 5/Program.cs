using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Täljare?");
            int t = int.Parse(Console.ReadLine());*/
            Console.WriteLine("Skriv ett bråk (a/b)");
            string text = Console.ReadLine();
            string[]delar = text.Split('/');
            int t = int.Parse(delar[0]);
            int n = int.Parse(delar[1]);
            int hel = t / n;
            int rest = t % n;
            Console.WriteLine($"{t}/{n} blir {hel} {rest}/{n} i blandad form");
            //Console.WriteLine("{0}/{1} blir {2} {3}/{1} i blandad form", t, n, hel,rest);
            Console.ReadKey();
        }
    }
}
