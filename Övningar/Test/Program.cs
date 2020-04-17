using System;
using System.Collections.Generic;
using System.IO;

namespace Test
{
    class Program
    {
        static List<Elev> elever = new List<Elev>();
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

        }

        static void LäggTill(string namn, double prov1, double prov2)
        {
            using (StreamWriter sw = new StreamWriter("resultat.txt", true))
            {
                sw.WriteLine(namn + " " + prov1 + " " + prov2);
            }
        }

        static void SkapaLista()
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("resultat.txt"))
                {
                    string line;
                    elever.Clear();
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Console.WriteLine(line);
                        string[] words = line.Split(" ");
                        string namn = words[0];
                        double prov1 = double.Parse(words[1]);
                        double prov2 = double.Parse(words[2]);
                        Elev elev = new Elev(namn, prov1, prov2);
                        elever.Add(elev);
                        using (StreamWriter sw = new StreamWriter("total.txt", true))
                        {
                            sw.WriteLine(namn + "\t" + elev.Total());
                        }

                    }
                    elever.Sort();
                    elever.Reverse();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Valmöjligherer:");
            Console.WriteLine("1. Lägg till elev");
            Console.WriteLine("2. Skriv ut provresultat");
            Console.WriteLine("3. Avsluta");
            Console.Write("\r\nVal: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Namn:");
                    string namn = Console.ReadLine();
                    Console.WriteLine("Prov 1:");
                    double prov1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Prov 2:");
                    double prov2 = double.Parse(Console.ReadLine());
                    LäggTill(namn,prov1,prov2);
                    return true;
                case "2":
                    Console.WriteLine("Provgräns:");
                    int provgräns = int.Parse(Console.ReadLine());
                    SkapaLista();
                    foreach (Elev e in elever)
                    {

                        if (e.Total() < provgräns)
                        {
                            Console.WriteLine(e.ToString() + " , Omprov");
                        }
                        else
                        {
                            Console.WriteLine(e.ToString() + " , Godkänd");
                        }
                    }
                    Console.WriteLine("Bästa resulatet: " + elever[0].Namn + " med " + elever[0].Total() + " poäng totalt");
                    Console.ReadKey();
                    return true;
                case "3":
                    Environment.Exit(0);
                    return false;
                default:
                    return true;
            }
        }

    }
}
