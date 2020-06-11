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

namespace YOSis
{
    public partial class FrmYonetici : Form
    {
        public FrmYonetici()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void Kaydet() {
            SqlCommand komut = new SqlCommand("insert into Admin (YoneticiAd,YoneticiSifre) values (@p1,@p2) ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtBox_id.Text); // Yonetici Adi,Kullanıcı adı eklenir.
            komut.Parameters.AddWithValue("@p2", txtBox_pw.Text);
            komut.ExecuteNonQuery();
        }

        private void Sil() {
            SqlCommand komut = new SqlCommand("delete from Admin where YoneticiID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBox_yoneticiID.Text);
            komut.ExecuteNonQuery();
        }

        private void Guncelle()
        {
            SqlCommand komut = new SqlCommand("update Admin set YoneticiAd=@p1,YoneticiSifre=@p2 where YoneticiID=@p3 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBox_id.Text);
            komut.Parameters.AddWithValue("@p2", txtBox_pw.Text);
            komut.Parameters.AddWithValue("@p3", txtBox_yoneticiID.Text);
            komut.ExecuteNonQuery();
        }

        private void FillTable() {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet5.Admin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet5.Admin);

        }
        private void FrmYonetici_Load(object sender, EventArgs e)
        {
            FillTable();

        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Kaydet();
                MessageBox.Show("Kayıt Başarılı.");
                FillTable();
            }
            catch (Exception)
            {

                MessageBox.Show("HATA ");
            }
            finally {
                bgl.baglanti().Close();
            }
           

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                Sil();
                MessageBox.Show("Silme İşlemi Başarılı..");
                FillTable();
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!!");
            }
            finally {
                bgl.baglanti().Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            // YoneticiID, Kullanıcı Adı, Sifre.
            txtBox_yoneticiID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBox_id.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtBox_pw.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Guncelle();
                MessageBox.Show("Güncelleme işlemi başarılı.");
                FillTable();
            }
            catch (Exception exception)
            {

                MessageBox.Show("HATA!!"+ exception);
            }
            finally {
                bgl.baglanti().Close();
            }
        }
    }
}
