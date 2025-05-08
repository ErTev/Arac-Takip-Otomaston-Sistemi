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
using System.Reflection;


namespace SQl_Ödev
{
    public partial class Araclar : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ERTUGRUL;Initial Catalog=OTO_SERVİS_YONETIM_VE_SATIS;Integrated Security=True;");
        public void AracGetir()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Araclar", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void Araclar_Load(object sender, EventArgs e)
        {
            AracGetir();
        }

        public Araclar()
        {
            InitializeComponent();
        }


        public string SecılıKayıtNo;
        public int SecılıKayıt;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SecılıKayıt = dataGridView1.SelectedCells[0].RowIndex;
            SecılıKayıtNo = dataGridView1.Rows[SecılıKayıt].Cells[0].Value.ToString();
            txt_Musterıd.Text = dataGridView1.Rows[SecılıKayıt].Cells[1].Value.ToString();
            txt_marka.Text = dataGridView1.Rows[SecılıKayıt].Cells[2].Value.ToString();
            txt_model.Text = dataGridView1.Rows[SecılıKayıt].Cells[3].Value.ToString();
            txt_ÜretımYılı.Text = dataGridView1.Rows[SecılıKayıt].Cells[4].Value.ToString();
            txt_fiyat.Text = dataGridView1.Rows[SecılıKayıt].Cells[5].Value.ToString();
            txt_stok.Text = dataGridView1.Rows[SecılıKayıt].Cells[6].Value.ToString();
        }

        private void btn_temzl_Click(object sender, EventArgs e)
        {
            txt_fiyat.Clear();
            txt_stok.Clear();
            txt_marka.Clear();
            txt_model.Clear();
            txt_Musterıd.Clear();
            txt_ÜretımYılı.Clear();
        }

        private void btn3_ekle_Click(object sender, EventArgs e)
        {
            SqlConnection bglnt = new SqlConnection("Data Source=ERTUGRUL;Initial Catalog=OTO_SERVİS_YONETIM_VE_SATIS;Integrated Security=True;");

            bglnt.Open();
            SqlCommand cmd = new SqlCommand("insert into Araclar (MusteriID,Marka,Model,UretimYili,Fiyat,StokDurumu) values (@MusteriID,@Marka,@Model,@UretimYili,@Fiyat,@StokDurumu)", bglnt);
            cmd.Parameters.Add("@MusteriID", Convert.ToInt32(txt_Musterıd.Text));
            cmd.Parameters.Add("@Marka", txt_marka.Text);
            cmd.Parameters.Add("@Model", txt_model.Text);
            cmd.Parameters.Add("@UretimYili", Convert.ToDateTime(txt_ÜretımYılı.Text));
            cmd.Parameters.Add("@Fiyat", Convert.ToDecimal(txt_fiyat.Text));
            cmd.Parameters.Add("@StokDurumu", Convert.ToInt32(txt_stok.Text));
            cmd.ExecuteNonQuery();

            MessageBox.Show("Kayıt Başarı ile Eklenmiştir");

            bglnt.Close();
            AracGetir();
            txt_Musterıd.Clear();
            txt_marka.Clear();
            txt_model.Clear();
            txt_fiyat.Clear();
            txt_ÜretımYılı.Clear();
            txt_stok.Clear();


        }

        private void btn3_sil_Click(object sender, EventArgs e)
        {
            int secılıkayıt = dataGridView1.SelectedCells[0].RowIndex;
            SecılıKayıtNo = dataGridView1.Rows[secılıkayıt].Cells[0].Value.ToString();
            DialogResult onay = MessageBox.Show(SecılıKayıtNo + " Nolu Aracın kayıdını Silmek İstediğinize Emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                SqlConnection baglanti = new SqlConnection("Data Source=ERTUGRUL;Initial Catalog=OTO_SERVİS_YONETIM_VE_SATIS;Integrated Security=True;");
                baglanti.Open();

                SqlCommand komut = new SqlCommand("delete from Araclar where AracID=@kimlik", baglanti);
                komut.Parameters.AddWithValue("@kimlik", dataGridView1.Rows[secılıkayıt].Cells[0].Value);
                komut.ExecuteNonQuery();
                MessageBox.Show("Silme İşlemi Tamamlandı.");
                baglanti.Close();
                AracGetir();

                txt_fiyat.Clear();
                txt_marka.Clear();
                txt_model.Clear();
                txt_Musterıd.Clear();
                txt_stok.Clear();
                txt_ÜretımYılı.Clear();



            }
        }

        private void btn3_gncll_Click(object sender, EventArgs e)
        {

           
            Program.DuzenlenecekID = dataGridView1.Rows[SecılıKayıt].Cells[0].Value.ToString();

            SqlConnection baglanti = new SqlConnection("Data Source=ERTUGRUL;Initial Catalog=OTO_SERVİS_YONETIM_VE_SATIS;Integrated Security=True;");
            baglanti.Open();

            SqlCommand duzenleme = new SqlCommand("UPDATE Araclar SET MusteriID=@MusteriID, Marka=@Marka, Model=@Model, UretimYili=@UretimYili, Fiyat=@Fiyat, StokDurumu=@StokDurumu WHERE AracID=@kimlik", baglanti);
            duzenleme.Parameters.Add("@MusteriID", Convert.ToInt32(txt_Musterıd.Text));
            duzenleme.Parameters.Add("@Marka", txt_marka.Text);
            duzenleme.Parameters.Add("@Model", txt_model.Text);
            duzenleme.Parameters.Add("@UretimYili", Convert.ToDateTime(txt_ÜretımYılı.Text));
            duzenleme.Parameters.Add("@Fiyat", Convert.ToDecimal(txt_fiyat.Text));
            duzenleme.Parameters.Add("@StokDurumu", Convert.ToInt32(txt_stok.Text));
            duzenleme.Parameters.Add("@kimlik", Program.DuzenlenecekID);

            duzenleme.ExecuteNonQuery();

            MessageBox.Show("Düzenleme Başarılı");
            AracGetir();
            baglanti.Close();

            txt_fiyat.Clear();
            txt_marka.Clear();
            txt_model.Clear();
            txt_Musterıd.Clear();
            txt_stok.Clear();
            txt_ÜretımYılı.Clear();


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
