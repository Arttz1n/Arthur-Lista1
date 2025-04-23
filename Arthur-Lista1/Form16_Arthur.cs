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
    public partial class Form16_Arthur: Form
    {

        public Form16_Arthur()
        {
            InitializeComponent();
        }

        private void Form16_Arthur_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double sb, i, c, sl;
                sb = Convert.ToDouble(textBox1.Text);
                c = sb * 0.1;
                i = (sb - c) * 0.05;
                sl = sb - (c + i);
                label8.Text = "R$" + Convert.ToString(c);
                label13.Text = "R$" + Convert.ToString(i);
                label16.Text = "R$" + Convert.ToString(sl);

            }
            catch (FormatException)
            {
                MessageBox.Show("preencha todos os campos, corretamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            label8.Text = "";
            label13.Text = "";
            label16.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
