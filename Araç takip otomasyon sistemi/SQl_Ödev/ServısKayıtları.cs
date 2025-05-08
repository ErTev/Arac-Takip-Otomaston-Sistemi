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
    public partial class ServısKayıtları : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ERTUGRUL;Initial Catalog=OTO_SERVİS_YONETIM_VE_SATIS;Integrated Security=True;");

        public void ServisKaydıGetir()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from ServisKayıtları", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
      
        private void ServısKayıtları_Load(object sender, EventArgs e)
        {
            ServisKaydıGetir();
        }

        public ServısKayıtları()
        {
            InitializeComponent();
        }


        public int SecılıKayıt;
        public string SecılıKayıtNo;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SecılıKayıt = dataGridView1.SelectedCells[0].RowIndex;
            SecılıKayıtNo = dataGridView1.Rows[SecılıKayıt].Cells[0].Value.ToString();
            txt_aracıID.Text = dataGridView1.Rows[SecılıKayıt].Cells[1].Value.ToString();
            txt_tarıh.Text = dataGridView1.Rows[SecılıKayıt].Cells[2].Value.ToString();
            txt_acıklama.Text = dataGridView1.Rows[SecılıKayıt].Cells[3].Value.ToString();
            txt_servisUcretı.Text = dataGridView1.Rows[SecılıKayıt].Cells[4].Value.ToString();
        }

        private void btn_temzl_Click(object sender, EventArgs e)
        {
            txt_acıklama.Clear();
            txt_aracıID.Clear();
            txt_servisUcretı.Clear();
            txt_tarıh.Clear();
        }

        private void btn3_ekle_Click(object sender, EventArgs e)
        {

            SqlConnection bglnt = new SqlConnection("Data Source=ERTUGRUL;Initial Catalog=OTO_SERVİS_YONETIM_VE_SATIS;Integrated Security=True;");
            bglnt.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO ServisKayıtları (AracID, ServiseGelisTarihi, ServisAciklamasi, ServisUcreti) VALUES (@AracID, @ServiseGelisTarihi, @ServisAciklamasi, @ServisUcreti)", bglnt);
            cmd.Parameters.AddWithValue("@AracID", Convert.ToInt32(txt_aracıID.Text));
            cmd.Parameters.AddWithValue("@ServiseGelisTarihi", Convert.ToDateTime(txt_tarıh.Text));
            cmd.Parameters.AddWithValue("@ServisAciklamasi", txt_acıklama.Text);
            cmd.Parameters.AddWithValue("@ServisUcreti", Convert.ToDecimal(txt_servisUcretı.Text));

            cmd.ExecuteNonQuery();
            bglnt.Close();

            MessageBox.Show("Kayıt Başarı ile Eklenmiştir");
            ServisKaydıGetir();
            txt_aracıID.Clear();
            txt_tarıh.Clear();
            txt_acıklama.Clear();
            txt_servisUcretı.Clear();

        }

        private void btn3_sil_Click(object sender, EventArgs e)
        {
            int secılıkayıt = dataGridView1.SelectedCells[0].RowIndex;
            SecılıKayıtNo = dataGridView1.Rows[secılıkayıt].Cells[0].Value.ToString();
            DialogResult onay = MessageBox.Show(SecılıKayıtNo + " Nolu Servis Kaydını Silmek İstediğinize Emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                SqlConnection baglanti = new SqlConnection("Data Source=ERTUGRUL;Initial Catalog=OTO_SERVİS_YONETIM_VE_SATIS;Integrated Security=True;");
                baglanti.Open();

                SqlCommand komut = new SqlCommand("delete from ServisKayıtları where ServisID=@kimlik", baglanti);
                komut.Parameters.AddWithValue("@kimlik", dataGridView1.Rows[secılıkayıt].Cells[0].Value);
                komut.ExecuteNonQuery();
                MessageBox.Show("Silme İşlemi Tamamlandı.");
                baglanti.Close();
                ServisKaydıGetir();

                ServisKaydıGetir();
                txt_aracıID.Clear();
                txt_tarıh.Clear();
                txt_acıklama.Clear();
                txt_servisUcretı.Clear();


            }
        }

        private void btn3_gncll_Click(object sender, EventArgs e)
        {
            Program.DuzenlenecekID = dataGridView1.Rows[SecılıKayıt].Cells[0].Value.ToString();

            SqlConnection baglanti = new SqlConnection("Data Source=ERTUGRUL;Initial Catalog=OTO_SERVİS_YONETIM_VE_SATIS;Integrated Security=True;");
            baglanti.Open();

            SqlCommand duzenleme = new SqlCommand("UPDATE ServisKayıtları SET AracID=@AracID, ServiseGelisTarihi=@ServiseGelisTarihi, ServisAciklamasi=@ServisAciklamasi, ServisUcreti=@ServisUcreti WHERE ServisID=@kimlik", baglanti);
            duzenleme.Parameters.Add("@AracID", Convert.ToInt32(txt_aracıID.Text));
            duzenleme.Parameters.Add("@ServiseGelisTarihi", Convert.ToDateTime(txt_tarıh.Text));
            duzenleme.Parameters.Add("@ServisAciklamasi", txt_acıklama.Text);
            duzenleme.Parameters.Add("@ServisUcreti", Convert.ToDecimal(txt_servisUcretı.Text));
            duzenleme.Parameters.Add("@kimlik", Program.DuzenlenecekID);

            duzenleme.ExecuteNonQuery();

            MessageBox.Show("Düzenleme Başarılı");
            ServisKaydıGetir();
            baglanti.Close();

            txt_aracıID.Clear();
            txt_tarıh.Clear();
            txt_acıklama.Clear();
            txt_servisUcretı.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            onyuz onyuz = new onyuz();
            onyuz.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
