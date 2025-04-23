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
    public partial class Form7_Arthur : Form
    {
        public Form7_Arthur()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double tv, vm, dp, lc;
                tv = Convert.ToDouble(textBox1.Text);
                vm = Convert.ToDouble(textBox3.Text);
                dp = tv * vm;
                lc = dp / 12;
                label15.Text = Convert.ToString(vm) + "Km";
                label17.Text = Convert.ToString(tv) + "h";
                label19.Text = Convert.ToString(dp) + "Km";
                label21.Text = Convert.ToString(lc) + "L";
            }
            catch (FormatException)
            {
                MessageBox.Show("preencha todos os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            label15.Text = "";
            label17.Text = "";
            label19.Text = "";
            label21.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form7_Arthur_Load(object sender, EventArgs e)
        {

        }
    }
}
