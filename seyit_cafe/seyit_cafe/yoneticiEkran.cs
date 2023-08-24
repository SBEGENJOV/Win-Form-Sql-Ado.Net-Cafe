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
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace seyit_cafe
{
    public partial class yoneticiEkran : Form
    {
        public yoneticiEkran()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=DESKTOP-5K7HMBT\\SQLEXPRESS;Database=sbcafe;Integrated Security=true;");
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "update siparisler set siparisler=@p1 where uyeID=@p2";
            command.Parameters.AddWithValue("@p1", textBox1.Text);
            command.Parameters.AddWithValue("@p2", textBox1.Tag);
            command.ExecuteNonQuery();
            con.Close();
            slistele();
            MessageBox.Show("Sipariş güncellendi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (deger==0)
            {
                DataGridViewRow satir = dataGridView1.CurrentRow;
                textBox1.Tag = satir.Cells["uyeID"].Value.ToString();
                textBox1.Text = satir.Cells["siparisler"].Value.ToString();
            }
            else if (deger==1)
            {

                DataGridViewRow satir = dataGridView1.CurrentRow;
                textBox1.Tag = satir.Cells["uyeID"].Value.ToString();
                textBox1.Text = satir.Cells["uyeID"].Value.ToString();
            }
            
        }
        public void slistele()
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = con;
            komut.CommandText = "select * from siparisler";
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
        }
        int deger;
        private void button4_Click(object sender, EventArgs e)
        {
            deger = 0;
            slistele();
        }
        public void ulistele()
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = con;
            komut.CommandText = "select * from uyeler";
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            deger = 1;
            ulistele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "delete from siparisler where uyeID=@p1";
            command.Parameters.AddWithValue("@p1", textBox1.Tag);
            command.ExecuteNonQuery();
            con.Close();
            slistele();
            MessageBox.Show("Sipariş silindi");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "delete from uyeler where uyeID=@p1";
            command.Parameters.AddWithValue("@p1", textBox1.Tag);
            command.ExecuteNonQuery();
            con.Close();
            ulistele();
            MessageBox.Show("Üye silindi");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select * from siparisler where uyeID=@p1";
            command.Parameters.AddWithValue("@p1", textBox1.Text);
            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
            command.ExecuteNonQuery();
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select * from uyeler where adSoyad=@p1";
            command.Parameters.AddWithValue("@p1", textBox1.Text);
            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
            command.ExecuteNonQuery();
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select * from siparisler order by fiyat desc ";
            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
            command.ExecuteNonQuery();
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select * from siparisler order by uyeID desc ";
            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
            command.ExecuteNonQuery();
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select * from siparisler order by fiyat";
            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
            command.ExecuteNonQuery();
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select * from siparisler where fiyat>=250 ";
            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
            command.ExecuteNonQuery();
            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select sum(fiyat) from siparisler ";
            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            object result = command.ExecuteScalar();
            MessageBox.Show(result.ToString());
            command.ExecuteNonQuery();
            con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select COUNT(*) from siparisler ";
            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            object result = command.ExecuteScalar();
            MessageBox.Show(result.ToString());
            command.ExecuteNonQuery();
            con.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select MAX(fiyat) from siparisler ";
            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            object result = command.ExecuteScalar();
            MessageBox.Show(result.ToString());
            command.ExecuteNonQuery();
            con.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select MIN(fiyat) from siparisler ";
            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            object result = command.ExecuteScalar();
            MessageBox.Show(result.ToString());
            command.ExecuteNonQuery();
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select * from siparisler where siparisler like @p1";
            command.Parameters.AddWithValue("@p1", "%" + textBox1.Text + "%");
            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
            command.ExecuteNonQuery();
            con.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select * from uyeler where adres like @p1";
            command.Parameters.AddWithValue("@p1", "%" + textBox1.Text + "%");
            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
            command.ExecuteNonQuery();
            con.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select * from uyeler order by uyeID desc ";
            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
            command.ExecuteNonQuery();
            con.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select COUNT(*)  from uyeler where uyeID>=0 ";
            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dataGridView1.DataSource = filldata;
            dr.Fill(filldata);
            object result = command.ExecuteScalar();
            command.ExecuteNonQuery();
            con.Close();




            con.Open();
            SqlCommand command1 = new SqlCommand();
            command1.Connection = con;
            command1.CommandText = "select * from uyeler where uyeID>=0 ";
            SqlDataAdapter dr1 = new SqlDataAdapter(command1);
            DataTable filldata1 = new DataTable();
            dataGridView1.DataSource = filldata1;
            dr1.Fill(filldata1);
            command1.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(result.ToString());
        }

        private void label12_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select COUNT(*)  from uyeler where uyeID<=0 ";
            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dataGridView1.DataSource = filldata;
            dr.Fill(filldata);
            object result = command.ExecuteScalar();
            command.ExecuteNonQuery();
            con.Close();


            con.Open();
            SqlCommand command1 = new SqlCommand();
            command1.Connection = con;
            command1.CommandText = "select * from uyeler where uyeID<=0 ";
            SqlDataAdapter dr1 = new SqlDataAdapter(command1);
            DataTable filldata1 = new DataTable();
            dataGridView1.DataSource = filldata1;
            dr1.Fill(filldata1);
            command1.ExecuteNonQuery();
            con.Close();


            MessageBox.Show(result.ToString());
        }

        private void label13_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command1 = new SqlCommand();
            command1.Connection = con;
            command1.CommandText = "select * from uyeler where cinsiyet=@p1";
            command1.Parameters.AddWithValue("@p1",comboBox1.Text);
            SqlDataAdapter dr1 = new SqlDataAdapter(command1);
            DataTable filldata1 = new DataTable();
            dataGridView1.DataSource = filldata1;
            dr1.Fill(filldata1);
            command1.ExecuteNonQuery();
            con.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command1 = new SqlCommand();
            command1.Connection = con;
            command1.CommandText = "select top 40 percent * from uyeler";
            SqlDataAdapter dr1 = new SqlDataAdapter(command1);
            DataTable filldata1 = new DataTable();
            dataGridView1.DataSource = filldata1;
            dr1.Fill(filldata1);
            command1.ExecuteNonQuery();
            con.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command1 = new SqlCommand();
            command1.Connection = con;
            command1.CommandText = "select adSoyad,count(*) from uyeler where adSoyad like @p1 group by adSoyad";
            command1.Parameters.AddWithValue("@p1", "%" + textBox1.Text + "%");
            SqlDataAdapter dr1 = new SqlDataAdapter(command1);
            DataTable filldata1 = new DataTable();
            dataGridView1.DataSource = filldata1;
            dr1.Fill(filldata1);
            command1.ExecuteNonQuery();
            con.Close();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command1 = new SqlCommand();
            command1.Connection = con;
            command1.CommandText = "select siparisler,count(*) from siparisler where siparisler like @p1 group by siparisler";
            command1.Parameters.AddWithValue("@p1", "%" + textBox3.Text + "%");
            SqlDataAdapter dr1 = new SqlDataAdapter(command1);
            DataTable filldata1 = new DataTable();
            dataGridView1.DataSource = filldata1;
            dr1.Fill(filldata1);
            command1.ExecuteNonQuery();
            con.Close();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command1 = new SqlCommand();
            command1.Connection = con;
            command1.CommandText = "select uyeID,cepNo,adSoyad,uyeID,sifre,count(*) from uyeler where uyeID>@p1 group by cepNo,adSoyad,uyeID,sifre";
            command1.Parameters.AddWithValue("@p1",textBox4.Text);
            SqlDataAdapter dr1 = new SqlDataAdapter(command1);
            DataTable filldata1 = new DataTable();
            dataGridView1.DataSource = filldata1;
            dr1.Fill(filldata1);
            command1.ExecuteNonQuery();
            con.Close();
        }

        private void yoneticiEkran_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fgec= new Form1();
            fgec.Show();
            this.Hide();
        }
    }
}
