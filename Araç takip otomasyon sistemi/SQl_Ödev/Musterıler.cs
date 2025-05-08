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
using System.IO;

namespace SQl_Ödev
{
    public partial class Musterıler : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ERTUGRUL;Initial Catalog=OTO_SERVİS_YONETIM_VE_SATIS;Integrated Security=True;");


        void MusteriGetir()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Musteriler", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public Musterıler()
        {
            InitializeComponent();
        }
        public string SecılıKayıtNo;
        public int SecılıKayıt;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SecılıKayıt= dataGridView1.SelectedCells[0].RowIndex;
            SecılıKayıtNo = dataGridView1.Rows[SecılıKayıt].Cells[0].Value.ToString();
            txt1_ad.Text = dataGridView1.Rows[SecılıKayıt].Cells[1].Value.ToString();
            txt1_soyad.Text = dataGridView1.Rows[SecılıKayıt].Cells[2].Value.ToString();
            txt1_mail.Text = dataGridView1.Rows[SecılıKayıt].Cells[3].Value.ToString();
            txt1_tel.Text = dataGridView1.Rows[SecılıKayıt].Cells[4].Value.ToString();
            txt_adres.Text = dataGridView1.Rows[SecılıKayıt].Cells[5].Value.ToString();

        }

        private void Musterıler_Load(object sender, EventArgs e)
        {
            MusteriGetir();
        }

        private void btn1_ekle_Click(object sender, EventArgs e)
        {
            SqlConnection bglnt = new SqlConnection("Data Source=ERTUGRUL;Initial Catalog=OTO_SERVİS_YONETIM_VE_SATIS;Integrated Security=True;");
            bglnt.Open();
            SqlCommand cmd = new SqlCommand("insert into Musteriler (Ad,Soyad,Mail,Telefon,Adres) values (@Ad,@Soyad,@Mail,@Telefon,@Adres)", bglnt);
            cmd.Parameters.Add("@Ad",txt1_ad.Text);
            cmd.Parameters.Add("@Soyad",txt1_soyad.Text);
            cmd.Parameters.Add("@Mail", txt1_mail.Text);
            cmd.Parameters.Add("@Telefon", txt1_tel.Text);
            cmd.Parameters.Add("@Adres", txt_adres.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarı ile Eklenmiştir");
            bglnt.Close();
            MusteriGetir();
            txt1_ad.Clear();
            txt1_soyad.Clear();
            txt1_tel.Clear();
            txt1_mail.Clear();
            txt_adres.Clear();


        }

        private void btn_temzl_Click(object sender, EventArgs e)
        {
            txt1_ad.Clear();
            txt1_soyad.Clear();
            txt1_tel.Clear();
            txt1_mail.Clear();
            txt_adres.Clear();
        }

        private void btn1_sil_Click(object sender, EventArgs e)
        {
            int secılıkayıt=dataGridView1.SelectedCells[0].RowIndex;
            SecılıKayıtNo = dataGridView1.Rows[secılıkayıt].Cells[0].Value.ToString();
            DialogResult onay = MessageBox.Show(SecılıKayıtNo+ " Nolu Müşterinin kayıdını Silmek İstediğinize Emin misiniz?","Silme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(onay==DialogResult.Yes)
            {
                SqlConnection baglanti = new SqlConnection("Data Source=ERTUGRUL;Initial Catalog=OTO_SERVİS_YONETIM_VE_SATIS;Integrated Security=True;");
                baglanti.Open();

                SqlCommand komut = new SqlCommand("delete from Musteriler where MusteriID=@kimlik",baglanti);
                komut.Parameters.AddWithValue("@kimlik", dataGridView1.Rows[secılıkayıt].Cells[0].Value);
                komut.ExecuteNonQuery();
                MessageBox.Show("Silme İşlemi Tamamlandı.");
                baglanti.Close();
                MusteriGetir();

                txt1_ad.Clear();
                txt1_soyad.Clear();
                txt1_tel.Clear();
                txt1_mail.Clear();
                txt_adres.Clear();


            }


        }

        private void btn1_gncll_Click(object sender, EventArgs e)
        {
            Program.DuzenlenecekID = dataGridView1.Rows[SecılıKayıt].Cells[0].Value.ToString();

            SqlConnection baglanti = new SqlConnection("Data Source=ERTUGRUL;Initial Catalog=OTO_SERVİS_YONETIM_VE_SATIS;Integrated Security=True;");
            baglanti.Open();

            SqlCommand duzenleme = new SqlCommand("UPDATE Musteriler SET Ad=@Ad, Soyad=@Soyad, Mail=@Mail, Telefon=@Telefon, Adres=@Adres WHERE MusteriID=@kimlik", baglanti);
            duzenleme.Parameters.Add("@Ad", txt1_ad.Text);
            duzenleme.Parameters.Add("@Soyad", txt1_soyad.Text);
            duzenleme.Parameters.Add("@Mail", txt1_mail.Text);
            duzenleme.Parameters.Add("@Telefon", txt1_tel.Text);
            duzenleme.Parameters.Add("@Adres", txt_adres.Text);
            duzenleme.Parameters.Add("@kimlik", Program.DuzenlenecekID);

            duzenleme.ExecuteNonQuery();

            MessageBox.Show("Düzenleme Başarılı");
            MusteriGetir();
            baglanti.Close();


            txt1_ad.Clear();
            txt1_soyad.Clear();
            txt1_tel.Clear();
            txt1_mail.Clear();
            txt_adres.Clear();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            onyuz onyuz = new onyuz();
            onyuz.Show();
            this.Hide();

        }
    }
}
