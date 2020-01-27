using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Styrketräning
{
    public partial class Form1 : Form
    {
        private List<Övning> övningar = new List<Övning>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnspara_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Övning sparad");
        }
    }
}
