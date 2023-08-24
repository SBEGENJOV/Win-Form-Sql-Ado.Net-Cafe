using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace seyit_cafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            uye_giris ugiris = new uye_giris();
            ugiris.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            uye_ol uogiris = new uye_ol();
            uogiris.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            yonetici_giris ygiris= new yonetici_giris();
            ygiris.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            mbilgi mgec = new mbilgi();
            mgec.Show();
            this.Hide();
        }
    }
}
