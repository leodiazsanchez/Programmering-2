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

namespace Övning_5._3_Klient
{
    public partial class Form1 : Form
    {
        TcpClient klient = new TcpClient();
        int port = 12345;

        public Form1()
        {
            InitializeComponent();
            klient.NoDelay = true;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (!klient.Connected) StartaAnslutning();
        }

        public async void StartaAnslutning()
        {
            try
            {
                IPAddress adress = IPAddress.Parse(textBox1.Text);
                await klient.ConnectAsync(adress, port);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
   
            }
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartaSändning(textBox2.Text);
        }

        public async void StartaSändning(string message)
        {
            byte[] utData = Encoding.Unicode.GetBytes(textBox2.Text);

            try
            {
                await klient.GetStream().WriteAsync(utData, 0, utData.Length);
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message, Text);
                return;
            }
        }
    }
}
