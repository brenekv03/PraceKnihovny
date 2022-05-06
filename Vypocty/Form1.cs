using CelaCisla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vypocty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            MessageBox.Show("Součet je: " +  Operace.Soucet(x, y));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int zbytek = 0;
            MessageBox.Show("Podíl je: " + Operace.CelociselnyPodil(x, y, out zbytek) + " a zbytek je: " + zbytek); 
        }
    }
}
