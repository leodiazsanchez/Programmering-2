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
            tcpClient.Close();

            //Förhindra konsolen från att stängas
            Console.ReadKey();

        }
    }
}
