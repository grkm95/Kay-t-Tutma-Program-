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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=itelliKullanici;Integrated Security=True");
        


        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            bag.Open();
            SqlCommand ara = new SqlCommand("Select * from kayitlar where truser like '%" + textBox2.Text + "%'", bag);
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem kayit = new ListViewItem();
                kayit.Text = oku["persAd"].ToString();
                kayit.SubItems.Add(oku["persSoyad"].ToString());
                kayit.SubItems.Add(oku["calismaDurumu"].ToString());
                kayit.SubItems.Add(oku["iseGirTarih"].ToString());
                kayit.SubItems.Add(oku["iseCikTarih"].ToString());
                kayit.SubItems.Add(oku["altAlani"].ToString());
                kayit.SubItems.Add(oku["orgBirimi"].ToString());
                kayit.SubItems.Add(oku["pozisyon"].ToString());
                kayit.SubItems.Add(oku["persis"].ToString());
                kayit.SubItems.Add(oku["persLevel"].ToString());
                kayit.SubItems.Add(oku["truser"].ToString());
                kayit.SubItems.Add(oku["telNo"].ToString());
                kayit.SubItems.Add(oku["telHat"].ToString());
                kayit.SubItems.Add(oku["tarife"].ToString());
                kayit.SubItems.Add(oku["ekPaket"].ToString());
                listView1.Items.Add(kayit);
            }
            oku.Close();
            bag.Close();
            textBox2.Clear();
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
             listView1.Items.Clear();
            bag.Open();
            SqlCommand ara = new SqlCommand("Select * from kayitlar where telNo like '%" + textBox1.Text + "%'", bag);
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem kayit = new ListViewItem();
                kayit.Text = oku["persAd"].ToString();
                kayit.SubItems.Add(oku["persSoyad"].ToString());
                kayit.SubItems.Add(oku["calismaDurumu"].ToString());
                kayit.SubItems.Add(oku["iseGirTarih"].ToString());
                kayit.SubItems.Add(oku["iseCikTarih"].ToString());
                kayit.SubItems.Add(oku["altAlani"].ToString());
                kayit.SubItems.Add(oku["orgBirimi"].ToString());
                kayit.SubItems.Add(oku["pozisyon"].ToString());
                kayit.SubItems.Add(oku["persis"].ToString());
                kayit.SubItems.Add(oku["persLevel"].ToString());
                kayit.SubItems.Add(oku["truser"].ToString());
                kayit.SubItems.Add(oku["telNo"].ToString());
                kayit.SubItems.Add(oku["telHat"].ToString());
                kayit.SubItems.Add(oku["tarife"].ToString());
                kayit.SubItems.Add(oku["ekPaket"].ToString());
                listView1.Items.Add(kayit);
            }
            oku.Close();
            bag.Close();
            textBox1.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
