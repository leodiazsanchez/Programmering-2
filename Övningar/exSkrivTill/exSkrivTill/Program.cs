using System;
using System.IO;

namespace exSkrivTill
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("Test.txt",true))
                {
                    sw.WriteLine("fem");
                    sw.WriteLine("sex");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Kunde inte skriva till filen");
                Console.WriteLine(e.Message);
            }

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("Test.txt"))
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
