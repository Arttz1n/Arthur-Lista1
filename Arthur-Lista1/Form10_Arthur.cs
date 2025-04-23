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

namespace Arthur_Lista1
{
    public partial class Form10_Arthur : Form
    {
        public Form10_Arthur()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double comprimento, altura, largura, volume;
                comprimento = Convert.ToDouble(textBox1.Text);
                largura = Convert.ToDouble(textBox2.Text);
                altura = Convert.ToDouble(textBox3.Text);
                volume = (comprimento * altura) * largura;
                label21.Text = Convert.ToString(volume);
            }
            catch (FormatException)
            {
                MessageBox.Show("preencha todos os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label21.Text = "";
        }

        private void Form10_Arthur_Load(object sender, EventArgs e)
        {

        }
    }
}
