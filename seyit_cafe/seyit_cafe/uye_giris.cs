using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seyit_cafe
{
    public partial class uye_giris : Form
    {
        public static int deger;

        public uye_giris()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=DESKTOP-5K7HMBT\\SQLEXPRESS;Database=sbcafe;Integrated Security=true;");

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1();
            geri.Show();
            this.Hide();
        }
        public void pictureBox2_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from uyeler where cepNo='" + textBox1.Text + "'and sifre='" + textBox2.Text + "'";
            
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                
                MessageBox.Show("Hoşgeldiniz");
                siparis_sayfa sipSayfa = new siparis_sayfa();
                con.Close();
                sipSayfa.Show();
                this.Hide();
            }
            else
            {
                
                MessageBox.Show("Giriş başarısız");
                textBox1.Clear();
                textBox2.Clear();
            }
            musNo();
        }
        public void musNo()
        {
            con.Open();
            SqlCommand command = new SqlCommand("select uyeID from uyeler where cepNo='" + textBox1.Text + "'and sifre='" + textBox2.Text + "'", con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                deger = Convert.ToInt32(reader["uyeID"]);
            }
            reader.Close();
        }
       
    }
}
