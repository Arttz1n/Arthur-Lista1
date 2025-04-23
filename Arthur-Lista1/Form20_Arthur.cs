using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arthur_Lista1
{
    public partial class Form20_Arthur : Form
    {
        public Form20_Arthur()
        {
            InitializeComponent();
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nome, sobrenome, j;
                string n = Convert.ToString(textBox1.Text);
                nome = n;
                string s = Convert.ToString(textBox2.Text);
                sobrenome = s;
                j = n + " " + s;
                label8.Text = j;
            }
            catch (FormatException)
            {
                MessageBox.Show("preencha todos os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form20_Arthur_Load(object sender, EventArgs e)
        {

        }
    }
}
