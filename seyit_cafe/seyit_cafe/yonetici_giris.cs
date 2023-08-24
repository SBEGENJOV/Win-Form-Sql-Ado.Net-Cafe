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
    public partial class yonetici_giris : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-5K7HMBT\\SQLEXPRESS;Database=sbcafe;Integrated Security=true;");
        public yonetici_giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1();
            geri.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText="select * from yoneticigiris where kulad='" + textBox1.Text + "'and sifre='" + textBox2.Text+"'";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Hoşgeldiniz");
               yoneticiEkran go = new yoneticiEkran();
                go.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş başarısız");
                textBox1.Clear();
                textBox2.Clear();
            }

            con.Close();
        }
    }
}
