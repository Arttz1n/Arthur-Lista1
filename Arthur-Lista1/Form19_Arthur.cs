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
    public partial class Form19_Arthur : Form
    {
        public Form19_Arthur()
        {
            InitializeComponent();
        }

        private void Form19_Arthur_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int reg, ano, sem, mat;
                if (Convert.ToDouble(textBox1.Text) / 1000000 > 1)
                {
                    textBox1.Text = "";
                    label13.Text = "";
                    label16.Text = "";
                    label8.Text = "";
                } else if (Convert.ToDouble(textBox1.Text) / 1000000 < 0.1) {
                }
                reg = Convert.ToInt32(textBox1.Text);
                ano = reg / 10000;
                sem = (reg / 1000) % 10;
                mat = reg % 1000;
                label13.Text = "20" + Convert.ToString(ano);
                label16.Text = Convert.ToString(sem) + "° Semestre";
                label8.Text = "N. " + Convert.ToString(mat);
            } 
            catch (FormatException)
            {
                MessageBox.Show("Preencha todos os campos corretamente. \nO registro deve conter apenas 6 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label13.Text = "";
            label16.Text = "";
            label8.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
