using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;


namespace Server
{
    class Program
    {
        static TcpListener tcpListener;

        static void CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            tcpListener.Stop();
            Console.WriteLine("Servern stängdes av");
        }
        static void Main(string[] args)
        {
            Console.CancelKeyPress += new ConsoleCancelEventHandler(CancelKeyPress);
            //Skapa ett TcpListener-object, börja lyssna och vänta på anslutning
            int port = 8001;
            IPAddress myIp = IPAddress.Parse("127.0.0.1");
            tcpListener = new TcpListener(myIp, port);
            tcpListener.Start();

            while (true)
            {
                try
                {
                    Console.WriteLine("Väntar på anslutning...");
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
                    Byte[] bSend = System.Text.Encoding.ASCII.GetBytes("Tack!");
                    socket.Send(bSend);
                    Console.WriteLine("Svar skickat");
                    //Stäng anslutningen till just den här klienten
                    socket.Close();
                    //Sluta lyssna efter trafik
                }
                catch (Exception e)
                {

                    Console.WriteLine("Error: " + e.Message);
                }
               
            }


        }
    }
}
