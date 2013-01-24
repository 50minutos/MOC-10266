using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _003_EventHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //button1.Click += new EventHandler(TratarClique);

            button1.Click += TratarClique;
        }
        
        //button1.Click (evento) -> EventHandler (delegate) -> TratarClique (método)

        private void TratarClique(Object o, EventArgs ea)
        {
            MessageBox.Show("Blz?");
        }
    }
}
