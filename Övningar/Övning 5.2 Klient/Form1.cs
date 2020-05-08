using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_5._2_Klient
{
    public partial class Klient : Form
    {
        public Klient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Port och adress
                int port = 8001;
                string address = "127.0.0.1";

                //Anslut till servern
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect(address, port);

                //Skriv in meddelande att skicka
                string message = textBox1.Text;


                //Konvertera meddelande till ASCII-bytes
                Byte[] bMessage = System.Text.Encoding.ASCII.GetBytes(message);

                //Skicka iväg meddelande
                Console.WriteLine("Skickar...");
                NetworkStream tcpStream = tcpClient.GetStream();
                tcpStream.Write(bMessage, 0, bMessage.Length);

                
            }
            catch (Exception error)
            {

                MessageBox.Show("Error: " + error.Message);
            }
        }
    }
}
