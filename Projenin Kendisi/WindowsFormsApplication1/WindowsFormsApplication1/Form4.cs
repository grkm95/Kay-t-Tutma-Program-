using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        

        private void Form4_Load(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form7 frm7 = new Form7();
            frm7.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
