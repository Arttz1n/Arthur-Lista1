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
    public partial class Form4_Arthur : Form
    {
        public Form4_Arthur()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            int F, C;
            C = Convert.ToInt32(textBox1.Text);
            F = (9 * C + 160) / 5;
            label8.Text = Convert.ToString(F) + "°F";
        }
            catch (FormatException)
            {
                MessageBox.Show("preencha todos os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label8.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Arthur_Load(object sender, EventArgs e)
        {

        }
    }
}
