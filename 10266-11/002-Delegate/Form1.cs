using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _002_Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Numeros(object sender, EventArgs e)
        {
            x.SelectedText = ((Button)sender).Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //PI
            x.Text = Math.PI.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //E
            x.Text = Math.E.ToString(); //Euler
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //1/x
            double n = 1 / Double.Parse(x.Text);

            x.Text = n.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //x²
            double n = Math.Pow(Double.Parse(x.Text), 2);

            x.Text = n.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //x³
            double n = Math.Pow(Double.Parse(x.Text), 3);

            x.Text = n.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //sqrt
            double n = Math.Sqrt(Double.Parse(x.Text));

            x.Text = n.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //sin
            double n = Double.Parse(x.Text);

            n = n * Math.PI / 180;

            n = Math.Sin(n);

            x.Text = n.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //cos
            double n = Double.Parse(x.Text);

            n = n * Math.PI / 180;

            n = Math.Cos(n);

            x.Text = n.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //tan
            double n = Double.Parse(x.Text);

            n = n * Math.PI / 180;

            n = Math.Tan(n);

            x.Text = n.ToString();
        }
    }
}
