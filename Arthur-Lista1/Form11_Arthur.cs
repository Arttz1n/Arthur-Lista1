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
    public partial class Form11_Arthur : Form
    {
        public Form11_Arthur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double n1, r1, r2;
                n1 = Convert.ToDouble(textBox1.Text);

                r1 = n1 * n1;
                r2 = r1 * n1;

                label8.Text = Convert.ToString(r1);
                label12.Text = Convert.ToString(r2);
            }
            catch (FormatException)
            {
                MessageBox.Show("preencha todos os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label8.Text = "";
            label12.Text = "";
        }

        private void Form11_Arthur_Load(object sender, EventArgs e)
        {

        }
    }
}
