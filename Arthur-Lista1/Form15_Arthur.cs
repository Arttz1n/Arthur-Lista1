using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Arthur_Lista1
{
    public partial class Form15_Arthur: Form
    {
        public Form15_Arthur()
        {
            InitializeComponent();
        }

        private void Form15_Arthur_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
            double v1, v2;
            v1 = Convert.ToDouble(textBox1.Text);
            v2 = v1 / 3.6;
            label8.Text = v2.ToString("F2") + "M/s";
        }
            catch (FormatException)
            {
                MessageBox.Show("preencha todos os campos, corretamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
