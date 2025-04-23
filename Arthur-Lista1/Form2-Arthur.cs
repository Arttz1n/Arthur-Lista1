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
    public partial class Form2_Arthur : Form
    {
        public Form2_Arthur()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n1, n2, r;
                n1 = int.Parse(textBox1.Text);
                n2 = int.Parse(textBox3.Text);
                r = n1 + n2;
                label8.Text = Convert.ToString(r);
            }
            catch (FormatException)
            {
                MessageBox.Show("preencha todos os campos, corretamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            label8.Text = "";
        }

        private void Form2_Arthur_Load(object sender, EventArgs e)
        {

        }
    }
}
