using Practica_Examen.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double m1 = double.Parse(textBox1.Text);
            double m2 = double.Parse(textBox2.Text);
            double m3 = double.Parse(textBox3.Text);
            double m4 = double.Parse(textBox4.Text);
            double m5 = double.Parse(textBox5.Text);
            double m6 = double.Parse(textBox6.Text);

            //llamar a la clase
            Calculadoraa suemi = new Calculadoraa(m1, m2, m3, m4, m5, m6);

            //depositar resultado
            textBox7.Text = suemi.Calculo_total().ToString();
            textBox8.Text = suemi.Calculo_Descuento().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
