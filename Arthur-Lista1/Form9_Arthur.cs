using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arthur_Lista1
{
    public partial class Form9_Arthur : Form
    {
        public Form9_Arthur()
        {
            InitializeComponent();

        }
        public double A, B, C, D;
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click_1(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double ABS, ACS, ADS, BCS, BDS, CDS, ABM, ACM, ADM, BCM, BDM, CDM;
                A = Convert.ToDouble(textBox1.Text);
                B = Convert.ToDouble(textBox2.Text);
                C = Convert.ToDouble(textBox3.Text);
                D = Convert.ToDouble(textBox4.Text);

                //soma
                ABS = A + B;
                ADS = A + C;
                ACS = A + D;
                BCS = B + C;
                BDS = B + D;
                CDS = C + D;
                label44.Text = ABS.ToString();
                label17.Text = ACS.ToString();
                label22.Text = ADS.ToString();
                label30.Text = BDS.ToString();
                label35.Text = BCS.ToString();
                label40.Text = CDS.ToString();

                A = Convert.ToDouble(textBox1.Text);
                B = Convert.ToDouble(textBox2.Text);
                C = Convert.ToDouble(textBox3.Text);
                D = Convert.ToDouble(textBox4.Text);

                //multiplicação
                ABM = A * B;
                ACM = A * C;
                ADM = A * D;
                BCM = B * C;
                BDM = B * D;
                CDM = C * D;
                label52.Text = ABM.ToString();
                label50.Text = ADM.ToString();
                label48.Text = ACM.ToString();
                label34.Text = BDM.ToString();
                label21.Text = BCM.ToString();
                label15.Text = CDM.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Arthur_Load(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click_1(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click_1(object sender, EventArgs e)
        {

        }

        private void label35_Click_1(object sender, EventArgs e)
        {

        }

        private void label21_Click_1(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label44.Text = "";
            label52.Text = "";
            label17.Text = "";
            label50.Text = "";
            label22.Text = "";
            label48.Text = "";
            label30.Text = "";
            label34.Text = "";
            label35.Text = "";
            label21.Text = "";
            label40.Text = "";
            label15.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label19_Click_1(object sender, EventArgs e)
        {

        }
    }
}
