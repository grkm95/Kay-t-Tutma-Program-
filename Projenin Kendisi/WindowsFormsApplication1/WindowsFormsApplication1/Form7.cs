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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();

        }
        SqlConnection bag = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=itelliKullanici;Integrated Security=True");
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            textBox6.Visible = false;
            
            SqlCommand veri = new SqlCommand("select * from kayitlar where persAd", bag);
            SqlDataReader oku =  veri.ExecuteReader();
            bag.Open();
           // oku = veri.ExecuteReader();
          //  listView1.Items.Clear();
            while (oku.Read())
            {

                //oku["id"].ToString()
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

        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try { 
                label20.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
              //  dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[4].Text;
               //dateTimePicker2.Text = listView1.SelectedItems[0].SubItems[5].Text;
                 textBox4.Text = listView1.SelectedItems[0].SubItems[4].Text;
               textBox5.Text = listView1.SelectedItems[0].SubItems[5].Text;
                textBox10.Text = listView1.SelectedItems[0].SubItems[6].Text;
                textBox9.Text = listView1.SelectedItems[0].SubItems[7].Text;
                textBox8.Text = listView1.SelectedItems[0].SubItems[8].Text;
                textBox7.Text = listView1.SelectedItems[0].SubItems[9].Text;
                textBox6.Text = listView1.SelectedItems[0].SubItems[10].Text;
                textBox11.Text = listView1.SelectedItems[0].SubItems[11].Text;
                textBox15.Text = listView1.SelectedItems[0].SubItems[12].Text;
                textBox14.Text = listView1.SelectedItems[0].SubItems[13].Text;
                textBox13.Text = listView1.SelectedItems[0].SubItems[14].Text;
                textBox12.Text = listView1.SelectedItems[0].SubItems[15].Text;
            }
           catch
            {

            }
           
        }

        


        private void dveri_oku()
        {

            SqlCommand veri = new SqlCommand("select * from kayitlar ", bag); //where id =" + label20.Text

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
            try { 
            
                bag.Open();
                SqlCommand guncelle = new SqlCommand("update kayitlar set persAd='" + textBox1.Text + "',persSoyad='" + textBox2.Text + "',calismaDurumu='" + textBox3.Text + "',iseGirTarih='" + textBox4.Text + "',iseCikTarih='" + textBox5.Text  + "',altAlani='" + textBox10.Text + "',orgBirimi='" + textBox9.Text + "',pozisyon='" + textBox8.Text + "',persis='" + textBox7.Text + "',persLevel='" + textBox6.Text + "',truser='" + textBox11.Text + "',telNo='" + textBox15.Text + "',telHat='" + textBox14.Text + "',tarife='" + listBox1.Text + "',ekPaket='" + textBox12.Text + "' where id='" + label20.Text + "'    ", bag);   
                guncelle.ExecuteNonQuery();
                bag.Close();
                dveri_oku();
                MessageBox.Show("Güncelleme başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          catch
            {

                MessageBox.Show("Lütfen Güncellemek İstediğiniz Dersi Aşağıdaki Tablodan Seçiniz...");
            }
        }

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

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            bag.Open();
            SqlCommand ara = new SqlCommand("Select * from kayitlar where truser like '%" + textBox16.Text + "%'", bag);
            SqlDataReader oku = ara.ExecuteReader();
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

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
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

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dateTimePicker1.text());
            //dateTimePicker1.Text.ToString()
        }
       
    }
}
