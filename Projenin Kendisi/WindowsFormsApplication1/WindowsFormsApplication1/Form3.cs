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

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=itelliKullanici;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            this.Hide();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand kaydet = new SqlCommand("insert into login (kAdi,kSifre) values('" + textBox1.Text + "','" + textBox2.Text + "')", bag);
                bag.Open();
                kaydet.ExecuteNonQuery();
                bag.Close();
                MessageBox.Show("Kayıt başarılı.","Kayıt",MessageBoxButtons.OK,MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
            }

            catch
            {
                MessageBox.Show("Lütfen Girdiğiniz Bilgileri Kontrol Ediniz...");
            }

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
