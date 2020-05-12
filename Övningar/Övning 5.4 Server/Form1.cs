using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_5._4_Server
{
    public partial class Form1 : Form
    {
        TcpListener lyssnare;
        TcpClient klient;
        int port = 12345;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                lyssnare = new TcpListener(IPAddress.Any, port);
                lyssnare.Start();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }

            button1.Enabled = false;
            StartaMottagning();
        }

        public async void StartaMottagning()
        {
            try
            {
                klient = await lyssnare.AcceptTcpClientAsync();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;

            }
            StartaLäsning(klient);
        }

        public async void StartaLäsning(TcpClient k)
        {
            byte[] buffert = new byte[1024];
            int n = 0;
            try
            {
                n = await k.GetStream().ReadAsync(buffert, 0, buffert.Length);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
            string input =(Encoding.Unicode.GetString(buffert, 0, n));
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            switch (input)
            {
                case "Upp":
                    y -= 10;
                    pictureBox1.Location = new Point(x,y);
                    break;
                case "Ner":
                    y += 10;
                    pictureBox1.Location = new Point(x, y);
                    break;
                case "Höger":
                    x += 10;
                    pictureBox1.Location = new Point(x, y);
                    break;
                case "Vänster":
                    x -= 10;
                    pictureBox1.Location = new Point(x, y);
                    break;
                default:
                    break;
            }
            StartaLäsning(k);
        }


    }
}
