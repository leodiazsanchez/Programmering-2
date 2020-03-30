using System;
using System.IO;

namespace Uppgift_SR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Text du vill skriva:");
            string text = Console.ReadLine();
            Console.WriteLine("Namn på filen:");
            string namn = Console.ReadLine();
            Console.WriteLine("Vill du lägga till text (bool):");
            bool skrivaöver = bool.Parse(Console.ReadLine());
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamWriter sw = new StreamWriter(namn+".txt",skrivaöver))
                {
                    sw.WriteLine(text);
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }
    }
}
