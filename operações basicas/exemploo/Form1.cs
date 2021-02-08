using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemploo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, r;
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            r = n1 + n2;
            textBox3.Text = Convert.ToString(r);
            r = n1 - n2;
            textBox4.Text = Convert.ToString(r);
            r = n1 * n2;
            textBox5.Text = Convert.ToString(r);
            if(n2 == 0)
            {
                MessageBox.Show("nao exsite divisao por zero" , "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                r = n1 / n2;
                textBox6.Text = Convert.ToString(r);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("deseja sair?", "confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = "hora: " + DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
