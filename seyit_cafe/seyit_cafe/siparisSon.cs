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
    public partial class siparisSon : Form
    {
        public siparisSon()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=DESKTOP-5K7HMBT\\SQLEXPRESS;Database=sbcafe;Integrated Security=true;");

        private void siparisSon_Load(object sender, EventArgs e)
        {
            if (mbilgi.uyeno<0)
            {
                SqlCommand komut = new SqlCommand();
                con.Open();
                komut.Connection = con;
                komut.CommandText = "select top 1 siparisler from siparisler where uyeId=@p1 order by siparisler";
                komut.Parameters.AddWithValue("@p1", mbilgi.uyeno);
                SqlDataAdapter dr = new SqlDataAdapter(komut);
                DataTable filldata = new DataTable();
                dr.Fill(filldata);
                object result = komut.ExecuteScalar();
                listBox1.Items.Add(result);
                con.Close();
            }
            else
            {
                listBox1.Items.Add(siparis_sayfa.siparis);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
