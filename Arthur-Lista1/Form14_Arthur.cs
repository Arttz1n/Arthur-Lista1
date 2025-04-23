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
    public partial class Form14_Arthur: Form
    {
        public Form14_Arthur()
        {
            InitializeComponent();
        }

        private void Form14_Arthur_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double val1, val2, media;
                val1 = Convert.ToDouble(textBox1.Text);
                val2 = Convert.ToDouble(textBox2.Text);
                media = (val1 + val2) / 2;
                label8.Text = Convert.ToString(media);
            }
            catch (FormatException)
            {
                MessageBox.Show("preencha todos os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label8.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
