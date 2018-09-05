using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        // SQL Connection 
        SqlConnection bag = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=itelliKullanici;Integrated Security=True");
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kAdi = textBox1.Text; //kullanıcı adı string veri
            string kSifre = textBox2.Text; //kullanıcı sifresi string veri
            SqlCommand kmt = new SqlCommand("select count (*) from login where kAdi =@kAdi and kSifre =@kSifre", bag); //tablo bağlantısı
            kmt.Parameters.AddWithValue("@kAdi", kAdi);
            kmt.Parameters.AddWithValue("@kSifre", kSifre);
            bag.Open();
            int sonuc = int.Parse(kmt.ExecuteScalar().ToString());
            bag.Close();

            if (sonuc == 0)
            {
                MessageBox.Show("Bilgilerinizi Kontrol Ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                //MessageBox.Show("Giriş başarılı.", "Hoşgeldiniz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form4 frm4 = new Form4();
                frm4.Show();
                

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
                     Application.Exit();
           
        }
    }
}
