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

namespace Övning_5._4_Klient
{
    public partial class Klient : Form
    {
        TcpClient klient = new TcpClient();
        int port = 12345;
        string input = "";

        public Klient()
        {
            InitializeComponent();
            klient.NoDelay = true;
        }

        private void btnAnslut_Click(object sender, EventArgs e)
        {
            if (!klient.Connected) StartaAnslutning();
        }


        public async void StartaAnslutning()
        {
            try
            {
                IPAddress adress = IPAddress.Parse(tbxIP.Text);
                await klient.ConnectAsync(adress, port);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;

            }
            btnAnslut.Enabled = false;
        }


        public async void StartaSändning(string message)
        {
            byte[] utData = Encoding.Unicode.GetBytes(input);

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

        private void btnUpp_Click(object sender, EventArgs e)
        {
            input = "Upp";
            StartaSändning(input);
        }

        private void btnHöger_Click(object sender, EventArgs e)
        {
            input = "Höger";
            StartaSändning(input);
        }

        private void btnNer_Click(object sender, EventArgs e)
        {
            input = "Ner";
            StartaSändning(input);
        }

        private void btnVänster_Click(object sender, EventArgs e)
        {
            input = "Vänster";
            StartaSändning(input);
        }
    }
}
