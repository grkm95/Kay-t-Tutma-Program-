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
    public partial class Form6 : Form
    {
        public Form6()
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

        private void veri_oku()
        {

            SqlCommand veri = new SqlCommand("select * from kayitlar", bag);
            SqlDataReader oku = null;
            bag.Open();
            oku = veri.ExecuteReader();
            listView1.Items.Clear();
            while (oku.Read())
            {
                ListViewItem kayit = new ListViewItem();
                kayit.Text = oku["id"].ToString();
                kayit.SubItems.Add(oku["persAd"].ToString());
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


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand kaydet = new SqlCommand("insert into kayitlar (persAd,persSoyad,calismaDurumu,iseGirTarih,iseCikTarih,altAlani,orgBirimi,pozisyon,persis,persLevel,truser,telNo,telHat,tarife,ekPaket) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "', '" + textBox10.Text + "', '" + textBox9.Text + "', '" + textBox8.Text + "', '" + textBox7.Text + "', '" + textBox6.Text + "', '" + textBox11.Text + "', '" + textBox15.Text + "', '" + textBox14.Text + "', '" + listBox1.Text + "', '" + textBox12.Text + "')", bag);
                bag.Open(); //bağlantı açılıyor
                kaydet.ExecuteNonQuery();//sql de etkilenen satır sayısını döndürür.
                bag.Close();//bağlantı kapandı
                veri_oku();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox14.Clear();
                textBox15.Clear();
              //  MessageBox.Show("Kayıt başarılı.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Lütfen Girdiğiniz Bilgileri Kontrol Ediniz...");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
