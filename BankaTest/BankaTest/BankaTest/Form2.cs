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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5VIVL0L; Initial Catalog=DbBankaTest; Integrated Security=True");
        

        private void Form2_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLKISILER ", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[1] + " " + dr[2];
                lbltc.Text = dr[3].ToString();
                lbltelefon.Text = dr[4].ToString();
                lblhesap.Text = dr[5].ToString();
            }
            baglanti.Close();
           
        }

        private void btngonder_Click(object sender, EventArgs e)
        {
            //Gönderilen Hesabın Para Artışı 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLHESAP set BAKIYE=BAKIYE+@p1 where HESAPNO=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", Convert.ToDecimal(txttutar.Text));
            komut.Parameters.AddWithValue("@p2", mskhesapno.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İslem Gerçekleşti");



            //Gönderen Hesabın Para Azalışı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("update TBLHESAP set BAKIYE=BAKIYE-@k1 where HESAPNO=@k2", baglanti);
            komut2.Parameters.AddWithValue("@k1", Convert.ToDecimal(txttutar.Text));
            komut2.Parameters.AddWithValue("@k2", lblhesap.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            

        }
    }
}
