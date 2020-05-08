using System;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Text;


namespace Klient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Port och adress
                int port = 8001;
                string address = "127.0.0.1";

                //Anslut till servern
                Console.WriteLine("Ansluter...");
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect(address, port);
                Console.WriteLine("Ansluten!");

                //Skriv in meddelande att skicka
                Console.Write("Skriv in ditt meddelande: ");
                string message = Console.ReadLine();


                //Konvertera meddelande till ASCII-bytes
                Byte[] bMessage = System.Text.Encoding.ASCII.GetBytes(message);

                //Skicka iväg meddelande
                Console.WriteLine("Skickar...");
                NetworkStream tcpStream = tcpClient.GetStream();
                tcpStream.Write(bMessage, 0, bMessage.Length);
                byte[] bRead = new byte[256];
                int bReadSize = tcpStream.Read(bRead, 0, bRead.Length);
                string read = "";
                for (int i = 0; i < bReadSize; i++)
                {
                    read += Convert.ToChar(bRead[i]);
                }
                Console.WriteLine("Servern säger: " + read);
                tcpClient.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e.Message);
            }



        }
    }
}
