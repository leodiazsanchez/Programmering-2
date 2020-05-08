using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Övning_5._2_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static TcpListener tcpListener;
        private void button1_Click(object sender, EventArgs e)
        {
            int port = 8001;
            IPAddress myIp = IPAddress.Parse("127.0.0.1");
            tcpListener = new TcpListener(myIp, port);
            tcpListener.Start();
            //Någon försöker ansluta. Acceptera anslutningen

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
                    textBox1.AppendText(message);
                    textBox1.AppendText(Environment.NewLine);
                    //Stäng anslutningen till just den här klienten
                    socket.Close();
                    //Sluta lyssna efter trafik
                }
                catch (Exception error)
                {

                    Console.WriteLine("Error: " + error.Message);
                }

            }

        }
      
    }
}
