using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;


namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Väntar på anslutning...");
            //Skapa ett TcpListener-object, börja lyssna och vänta på anslutning
            int port = 8001;
            IPAddress myIp = IPAddress.Parse("127.0.0.1");
            TcpListener tcpListener = new TcpListener(myIp, port);
            tcpListener.Start();

            //Någon försöker ansluta. Acceptera anslutningen
            Socket socket = tcpListener.AcceptSocket();
            Console.WriteLine("Anslutnig accepterad från " + socket.RemoteEndPoint);
            //Tag emot meddelandet
            Byte[] bMessage = new Byte[256];
            int messageSize = socket.Receive(bMessage);
            Console.WriteLine("Meddelandet mottogs");
            //Konvertera meddelandet till en string-variabel och skriv ut
            string message = "";
            foreach (char character in bMessage)
            {
                message += character;
            }
            Console.WriteLine("Meddelande: " + message);
            //Stäng anslutningen till just den här klienten
            socket.Close();
            //Sluta lyssna efter trafik
            tcpListener.Stop();
            //Förhindra konsolen från att stängas
            Console.WriteLine("Väntar på anslutning...");
            Console.ReadKey();
        }
    }
}
