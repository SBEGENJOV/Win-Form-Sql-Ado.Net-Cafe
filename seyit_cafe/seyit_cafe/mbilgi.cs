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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace seyit_cafe
{
    public partial class mbilgi : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-5K7HMBT\\SQLEXPRESS;Database=sbcafe;Integrated Security=true;");

        public mbilgi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1();
            geri.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            uye_ol uye_Ol = new uye_ol();
            uye_Ol.Show();
            this.Hide();
        }
       public static int uyeno;
        public int uyeıdson()
        {
            //con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM uyeler order by uyeID desc ", con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                uyeno = Convert.ToInt32(reader["uyeID"]);
            }
            reader.Close();
            // con.Close();
            return uyeno - 1;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into uyeler (uyeID,cepNo,adSoyad,cinsiyet,sifre,mail,adres) " +
                "values (@p0,@p1,@p2,@p3,@p4,@p5,@p6)";
            cmd.Parameters.AddWithValue("@p0", uyeıdson());
            cmd.Parameters.AddWithValue("@p1", textBox2.Text);
            cmd.Parameters.AddWithValue("@p2", textBox1.Text);
            cmd.Parameters.AddWithValue("@p4", "uye degil");
            cmd.Parameters.AddWithValue("@p5", "uye degil");
            cmd.Parameters.AddWithValue("@p3", "uye degil");
            cmd.Parameters.AddWithValue("@p6", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("bilgiler tamam, sipariş verebilirsiniz");
            siparis_sayfa sgec = new siparis_sayfa();
            sgec.Show();
            this.Hide();
        }
    }
}
