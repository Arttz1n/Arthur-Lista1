using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arthur_Lista1
{
    public partial class Form18_Arthur: Form
    {
        public Form18_Arthur()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int data, dia, mes, ano, f;
                if (Convert.ToDouble(textBox1.Text) / 1000000 > 1)
                {
                    textBox1.Text = "";
                    label8.Text = "";
                }
                    data = Convert.ToInt32(textBox1.Text);
                dia = data / 10000;
                mes = (data / 100) % 100;
                ano = data % 100;
                f = ano * 10000 + mes * 100 + dia;
                label8.Text = Convert.ToString(f);
            }
            catch (FormatException)
            {
                MessageBox.Show("Preencha todos os campos corretamente.\nA data deve conter apenas 6 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label8.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form18_Arthur_Load(object sender, EventArgs e)
        {

        }
    }
}
