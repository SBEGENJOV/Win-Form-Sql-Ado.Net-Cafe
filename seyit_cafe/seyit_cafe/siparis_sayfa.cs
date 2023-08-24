using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace seyit_cafe
{
    public partial class siparis_sayfa : Form
    {
        public siparis_sayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1();
            geri.Show();
            this.Hide();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }
        public int fiyat;
        SqlConnection con = new SqlConnection("Server=DESKTOP-5K7HMBT\\SQLEXPRESS;Database=sbcafe;Integrated Security=true;");
        public static string siparis;
        private void button2_Click(object sender, EventArgs e)
        {
            sipHesap();
            
            if (uye_giris.deger > 0)
            {
                fiyat -= fiyat * 5 / 100;
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into siparisler (siparisler,uyeID,fiyat) " +
                    "values (@p1,@p2,@p3)";
                cmd.Parameters.AddWithValue("@p1", birlesikMetin);
                cmd.Parameters.AddWithValue("@p2", uye_giris.deger);
                cmd.Parameters.AddWithValue("@p3", fiyat);
                cmd.ExecuteNonQuery();
                con.Close();
                siparis = birlesikMetin;
                siparisSon sipgec = new siparisSon();
                sipgec.Show();
                this.Hide();
            }
            else
            {

                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into siparisler (siparisler,uyeID,fiyat) " +
                    "values (@p1,@p2,@p3)";
                cmd.Parameters.AddWithValue("@p1", birlesikMetin);
                cmd.Parameters.AddWithValue("@p2", mbilgi.uyeno);
                cmd.Parameters.AddWithValue("@p3", fiyat);
                cmd.ExecuteNonQuery();
                con.Close();
                siparisSon sipgec = new siparisSon();
                sipgec.Show();
                this.Hide();
                MessageBox.Show("kayıt eklendi");
            }
        }

        private void siparis_sayfa_Load(object sender, EventArgs e)
        {
           
        }
        public string birlesikMetin = "";
        public void sipHesap()
        {
            int checkedCount = 0;
            foreach (Control control in Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    checkedCount++;
                }
            }
            string[] siparisler = new string[checkedCount];
            for (int i = 0; i < checkedCount; i++)
            {
                if (checkBox1.Checked)
                {
                    siparisler[i] = checkBox1.Text;
                    fiyat += 70;
                    i++;
                }
                if (checkBox2.Checked)
                {
                    siparisler[i] = checkBox2.Text;
                    fiyat += 200;
                    i++;
                }
                if (checkBox3.Checked)
                {
                    siparisler[i] = checkBox3.Text;
                    fiyat += 75;
                    i++;
                }
                if (checkBox4.Checked)
                {
                    siparisler[i] = checkBox4.Text;
                    fiyat += 120;
                    i++;
                }
                if (checkBox5.Checked)
                {
                    siparisler[i] = checkBox5.Text;
                    fiyat += 50;
                    i++;
                }
                if (checkBox6.Checked)
                {
                    siparisler[i] = checkBox3.Text;
                    fiyat += 150;
                    i++;
                }
                if (checkBox7.Checked)
                {
                    siparisler[i] = checkBox7.Text;
                    fiyat += 50;
                    i++;
                }
                if (checkBox8.Checked)
                {
                    siparisler[i] = checkBox8.Text;
                    fiyat += 65;
                    i++;
                }
                if (checkBox9.Checked)
                {
                    siparisler[i] = checkBox9.Text;
                    fiyat += 75;
                    i++;
                }
                if (checkBox10.Checked)
                {
                    siparisler[i] = checkBox10.Text;
                    fiyat += 40;
                    i++;
                }
                if (checkBox11.Checked)
                {
                    siparisler[i] = checkBox11.Text;
                    fiyat += 70;
                    i++;
                }
                if (checkBox12.Checked)
                {
                    siparisler[i] = checkBox12.Text;
                    fiyat += 60;
                    i++;
                }
                if (checkBox13.Checked)
                {
                    siparisler[i] = checkBox13.Text;
                    fiyat += 80;
                    i++;
                }
                if (checkBox14.Checked)
                {
                    siparisler[i] = checkBox14.Text;
                    fiyat += 50;
                    i++;
                }
                if (checkBox15.Checked)
                {
                    siparisler[i] = checkBox15.Text;
                    fiyat += 20;
                    i++;
                }
                if (checkBox16.Checked)
                {
                    siparisler[i] = checkBox16.Text;
                    fiyat += 15;
                    i++;
                }
                if (checkBox17.Checked)
                {
                    siparisler[i] = checkBox17.Text;
                    fiyat += 25;
                    i++;
                }
                if (checkBox18.Checked)
                {
                    siparisler[i] = checkBox18.Text;
                    fiyat += 25;
                    i++;
                }
                if (checkBox19.Checked)
                {
                    siparisler[i] = checkBox19.Text;
                    fiyat += 80;
                    i++;
                }
                if (checkBox20.Checked)
                {
                    siparisler[i] = checkBox20.Text;
                    fiyat += 60;
                    i++;
                }
                if (checkBox21.Checked)
                {
                    siparisler[i] = checkBox21.Text;
                    fiyat += 50;
                    i++;
                }
                if (checkBox22.Checked)
                {
                    siparisler[i] = checkBox22.Text;
                    fiyat += 70;
                    i++;
                }
                if (checkBox23.Checked)
                {
                    siparisler[i] = checkBox23.Text;
                    fiyat += 40;
                    i++;
                }
                if (checkBox24.Checked)
                {
                    siparisler[i] = checkBox24.Text;
                    fiyat += 10;
                    i++;
                }
            }
            //----------------------------------------------------------------------------------
           
            for (int i = 0; i < siparisler.Length; i++)
            {
                foreach (string dizi in siparisler)
                {
                    birlesikMetin = string.Join(", ", siparisler);
                }
            }
            //------------------------------------------------------------------------------------
            birlesikMetin = birlesikMetin.TrimEnd(',', ' ');
        }
    }
    }

