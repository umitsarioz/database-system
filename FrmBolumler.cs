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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);

        }

        public void ekle() {
            SqlCommand komut = new SqlCommand("insert into Bolumler (BolumAd) values (@p1) ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBox_bolumAdi.Text);
            komut.ExecuteNonQuery();
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
        }

        public void sil() {

            SqlCommand komut = new SqlCommand("delete from Bolumler where BolumID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBox_bolumID.Text);
            komut.ExecuteNonQuery();
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
        }

        public void guncelle() { 
            SqlCommand komut = new SqlCommand("update Bolumler Set BolumAd=@p1 where BolumID=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", txtBox_bolumID.Text);
            komut.Parameters.AddWithValue("@p1", txtBox_bolumAdi.Text);
            komut.ExecuteNonQuery();
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                ekle();
                MessageBox.Show("Ekleme işlemi başarıyla gerçekleşti..");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA!!");
            }
            finally {
                bgl.baglanti().Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {      
            try
            {
                guncelle();
                MessageBox.Show("Tablo güncellendi..");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA!!");
            }
            finally {
                bgl.baglanti().Close();
             }
        } 

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            try
            {
                sil();
                MessageBox.Show("Silme işlemi başarıla gerçekleşti.");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA!!");
            }
            finally {
                bgl.baglanti().Close();
            }
        }

        int secilenIndex;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String bolumID;
            String bolumAdi;
            secilenIndex = dataGridView1.SelectedCells[0].RowIndex;
            bolumID = dataGridView1.Rows[secilenIndex].Cells[0].Value.ToString();
            bolumAdi = dataGridView1.Rows[secilenIndex].Cells[1].Value.ToString();

            txtBox_bolumAdi.Text = bolumAdi;
            txtBox_bolumID.Text = bolumID;
        }
    }
}
