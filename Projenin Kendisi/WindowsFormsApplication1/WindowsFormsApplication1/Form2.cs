using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //sql kütüphanesi

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //sql bağlantı komutu
        SqlConnection bag = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=itelliKullanici;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string kAdi = textBox1.Text;
            string kSifre = textBox2.Text;
            SqlCommand kmt = new SqlCommand("select count (*) from admin where kAdi =@kAdi and kSifre =@kSifre", bag);
            kmt.Parameters.AddWithValue("@kAdi",kAdi);
            kmt.Parameters.AddWithValue("@kSifre",kSifre);
            bag.Open();
            int sonuc = int.Parse(kmt.ExecuteScalar().ToString());
            bag.Close();
            if (sonuc == 0)
            {
                MessageBox.Show("Bilgilerinizi kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Giriş başarılı.", "Hoşgeldiniz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form3 frm3 = new Form3();
                frm3.Show();
               }
          
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
