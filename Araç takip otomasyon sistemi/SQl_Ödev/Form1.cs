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


namespace SQl_Ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    


      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_grs_Click(object sender, EventArgs e)
        {
            SqlConnection baglantı = new SqlConnection("Data Source=ERTUGRUL;Initial Catalog=OTO_SERVİS_YONETIM_VE_SATIS;Integrated Security=True;");
            baglantı.Open();

            SqlCommand komut = new SqlCommand("select * from Kullanıcılar where kullaniciAdi=@kullaniciAdi and sifre=@sifre", baglantı);
            komut.Parameters.AddWithValue("@kullaniciAdi", txt_kllnci.Text);
            komut.Parameters.AddWithValue("@sifre", txt_sıfre.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();

                onyuz onyuz = new onyuz();

                onyuz.ShowDialog();
            }

            else
            {
                MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre");
            }
        }

        private void btn_cks_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Çıkmak İstediğinize emin misiniz?", "Çıkış İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

     
    }
}
