using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Abstract_Factory;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBoxScnk.Text=="1")
            {
                listBox1.Items.Clear();
                Client Ekran = new Client(new FactoryLed());
               listBox1.Items.Add(Ekran.BuildTV());
              
            }
            else if (comboBoxScnk.Text == "2")
            {
                listBox1.Items.Clear();
                Client Ekran = new Client(new FactoryOled());
                listBox1.Items.Add(Ekran.BuildTV());
            }
        }
    }
}
