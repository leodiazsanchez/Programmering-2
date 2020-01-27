using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_på_överlagrade_metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många tärningar vill du kasta?");
            int antal = int.Parse(Console.ReadLine());
            Console.WriteLine("Sidor?");
            int sidor = int.Parse(Console.ReadLine());
            Console.WriteLine("Mata in tärningskast via sträng ([Antal]T[Sidor]");
            string tärning = Console.ReadLine();
            Console.WriteLine("Metod 1: " + (kasta(antal)));
            Console.WriteLine("Metod 2: " + (kasta(antal,sidor)));
            Console.WriteLine("Metod 3: " + (kasta(tärning)));
            Console.WriteLine(KastaTärning(Console.ReadLine()));
            Console.ReadKey();
        }

        static int kasta(int antal)
        {
            Random rnd = new Random();
            int[] värden = new int[antal];
            int summa = 0;
            for (int i = 0; i < antal; i++)
            {
                värden[i] = rnd.Next(1, 7);
                summa += värden[i];

            }
            return summa;
        }

        static int kasta(int antal, int sidor)
        {
            Random rnd = new Random();
            int[] värden = new int[antal];
            int summa = 0;
            for (int i = 0; i < antal; i++)
            {
                värden[i] = rnd.Next(1, sidor+1);
                summa += värden[i];

            }
            return summa;
        }

        static int kasta(string tärning)
        {
            Random rnd = new Random();
            string[] delar = tärning.Split('T');
            int antal = int.Parse(delar[0]);
            int sidor = int.Parse(delar[1]);
            int[] värden = new int[antal];
            int summa = 0;
            for (int i = 0; i < antal; i++)
            {
                int Tal = rnd.Next(1, sidor + 1);
                summa += Tal;
                Console.WriteLine(Tal);
            }
            return summa;
        }

        
        static int KastaTärning(string tärning)
        {
            Random rnd = new Random();
            string[] S = tärning.Split('T');
            int Summa = 0;
            for (int i = 0; i < int.Parse(S[0])-1; i++)
            {
                int Tal = rnd.Next(1, int.Parse(S[1]) + 1);
                Summa += Tal;
                Console.WriteLine(Tal);
            }
            return Summa;
        }

    }
}
