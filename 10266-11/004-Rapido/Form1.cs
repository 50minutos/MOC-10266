using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _004_Rapido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Duvido!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lerdo!!!");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (button1.Location.X == 12)
                button1.Location = new Point(174, button1.Location.Y);
            else
                button1.Location = new Point(12, button1.Location.Y);

        }
    }
}
