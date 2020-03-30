using System;
using System.IO;

namespace Slumpat_lösenord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Användarnamn:");
            string user = Console.ReadLine();


            string Lösen()
            {
                string lösenord = "";
                Random random = new Random();
                for (int i = 0; i < 3; i++)
                {
                    char gemen = Convert.ToChar(random.Next(97, 123));
                    lösenord += gemen;
                }
                for (int i = 0; i < 2; i++)
                {
                    char siffra = Convert.ToChar(random.Next(48, 58));
                    lösenord += siffra;
                }
                for (int i = 0; i < 2; i++)
                {
                    char versal = Convert.ToChar(random.Next(65, 91));
                    lösenord += versal;
                }
                return lösenord;
            }

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamWriter sw = new StreamWriter("Slump.txt"))
                {
                    sw.WriteLine(user + "\t" + Lösen());
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("Slump.txt"))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
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
