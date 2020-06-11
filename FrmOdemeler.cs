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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        public void guncelleme() {
            SqlCommand komut = new SqlCommand("update Borclar set OgrKalanBorc=@p1 where OgrId=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", txtBox_ogrID.Text);
            komut.Parameters.AddWithValue("@p1", txtBox_kalanBorc.Text);
            komut.ExecuteNonQuery();

            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet2.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet2.Borclar);

        }

        public void kasayaEkle() {
            SqlCommand komut = new SqlCommand("insert into Kasa (OdemeAy,OdemeMiktar) values (@p1,@p2)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtBox_odenenAy.Text);
            komut.Parameters.AddWithValue("@p2", txtBox_odenecekTutar.Text);
            komut.ExecuteNonQuery();
        }

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet2.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet2.Borclar);
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);

        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            String ogrID, ogrAd, ogrSoyad, Kalan;
            secilen = dGV_ogrBorc.SelectedCells[0].RowIndex;
            ogrID = dGV_ogrBorc.Rows[secilen].Cells[0].Value.ToString();
            ogrAd = dGV_ogrBorc.Rows[secilen].Cells[1].Value.ToString();
            ogrSoyad = dGV_ogrBorc.Rows[secilen].Cells[2].Value.ToString();
            Kalan = dGV_ogrBorc.Rows[secilen].Cells[3].Value.ToString();

            // Tanımlamalar ve atamalar yapıldıktan sonra Textboxt'ların text kısımlarına yukarıdakiler atanır.

            txtBox_ogrID.Text = ogrID;
            txtBox_ogrAd.Text = ogrAd;
            txtBox_ogrSoyad.Text = ogrSoyad;
            txtBox_kalanBorc.Text = Kalan;
            
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            int odenecekTutar, kalanBorc;
            odenecekTutar = Convert.ToInt32(txtBox_odenecekTutar.Text);
            kalanBorc = Convert.ToInt32(txtBox_kalanBorc.Text);

            if (kalanBorc > 0)
            {
                if (kalanBorc >= odenecekTutar)
                    kalanBorc = kalanBorc - odenecekTutar;
                else
                    MessageBox.Show("Bozuk para üstü yok,bozdur gel :)");
            }
            else if (kalanBorc == 0)
                MessageBox.Show("Borcunuz kalmamıştır.");
            else
                MessageBox.Show("Kalan Borç 0'dan kücük olamaz.??");

           //Kalanborç stringi verilir.
            txtBox_kalanBorc.Text = kalanBorc.ToString();


            try //Veritabananı için borçlar tablosunu günceller.
            {
                guncelleme();
                kasayaEkle();
                MessageBox.Show("Ödeme başarıyla gerçekleştirildi.");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA!! BORC HESAPLAMASINDA HATA !!");
            }
            finally {
                bgl.baglanti().Close();
            }

        

        }
    }
}
