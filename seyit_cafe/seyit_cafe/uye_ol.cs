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
    public partial class uye_ol : Form
    {
        public uye_ol()
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
        int uyeno;
        public int uyeıdson()
        {
            //con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM uyeler order by uyeID asc ", con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                uyeno = Convert.ToInt32(reader["uyeID"]);
            }
            reader.Close();
           // con.Close();
            return uyeno+1;
        }
        public void girisKontrol()
        {
            
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand();
            con.Open();
            cmd1.Connection = con;
            cmd1.CommandText = "select cepNo from uyeler where cepNo=@p1";
            cmd1.Parameters.AddWithValue("@p1", textBox3.Text);
            SqlDataAdapter dr = new SqlDataAdapter(cmd1);
            object result = cmd1.ExecuteScalar();
            cmd1.ExecuteNonQuery();
            con.Close();
            if (result==null)
            {
               SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into uyeler (uyeID,cepNo,adSoyad,cinsiyet,sifre,mail,adres) " +
                    "values (@p0,@p1,@p2,@p3,@p4,@p5,@p6)";
                cmd.Parameters.AddWithValue("@p0", uyeıdson());
                cmd.Parameters.AddWithValue("@p1", textBox3.Text);
                cmd.Parameters.AddWithValue("@p2", textBox2.Text);
                cmd.Parameters.AddWithValue("@p4", textBox1.Text);
                cmd.Parameters.AddWithValue("@p5", textBox4.Text);
                cmd.Parameters.AddWithValue("@p6", textBox5.Text);
                cmd.Parameters.AddWithValue("@p3", comboBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("kayıt eklendi");
            }
            else
            {
                MessageBox.Show("Girdiginiz Telefon numasarı ile üyelik yapıldı: " + result);
                textBox3.Text = null;
            }
            //MessageBox.Show(textBox3.Text.GetType() + "     " + result.ToString().GetType());
        }
        
    }
}
