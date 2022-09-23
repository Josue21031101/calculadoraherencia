using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraherencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            suma suma = new suma();
            textBox3.Text = suma.operar(double.Parse(textBox1.Text),
            double.Parse(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Restar restar = new Restar();
            textBox3.Text = restar.operar(double.Parse(textBox1.Text),
            double.Parse(textBox2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Divididir divididir = new Divididir();
            textBox3.Text = divididir.operar(double.Parse(textBox1.Text),
            double.Parse(textBox2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Multiplicar multiplicar = new Multiplicar();
            textBox3.Text = multiplicar.operar(double.Parse(textBox1.Text),
            double.Parse(textBox2.Text)).ToString();
        }
    }
}
