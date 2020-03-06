using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string str = txtOg.Text;
            char[] chars = new char[str.Length];
            for (int i = str.Length - 1, j = 0; i >= 0; --i, ++j)
            {
                chars[j] = str[i];
            }
            str = new String(chars);

            tbxNy.Text = str;
        }

    }
}
