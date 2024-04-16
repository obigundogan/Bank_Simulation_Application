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

namespace BankaTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5VIVL0L; Initial Catalog=DbBankaTest; Integrated Security=True");
        private void lnkkayıtol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLKISILER where HESAPNO=@p1 and SIFRE=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", mskhesapno.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 fr = new Form2();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız...");
            }
            baglanti.Close();

        }
    }
}
