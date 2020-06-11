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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim(); // Baglantı sınıfı acıldı.

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Personel (PersonalAdSoyad,PersonelDepartman) values (@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtBox_prsAdSoyad.Text);
                komut.Parameters.AddWithValue("@p2", txtBox_prsDep.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı..");
                FillTableAndRefresh();
            }
            catch (Exception)
            {
                MessageBox.Show("HATA!!");
            }
            finally
            {
                bgl.baglanti().Close();
            }


        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Personel set PersonalAdSoyad=@p1,PersonelDepartman=@p2 where PersonelID=@p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtBox_prsAdSoyad.Text);
                komut.Parameters.AddWithValue("@p2", txtBox_prsDep.Text);
                komut.Parameters.AddWithValue("@p3", txtBox_prsID.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Güncelleme Başarılı..");
                FillTableAndRefresh();
            }
            catch (Exception)
            {
                MessageBox.Show("HATA!!");
            }
            finally {
                bgl.baglanti().Close();
            }

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("delete from Personel where PersonelID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtBox_prsID.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti..");
                FillTableAndRefresh();
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!!!");
            }
            finally {
                bgl.baglanti().Close();
            }
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            FillTableAndRefresh();

        }

        private void FillTableAndRefresh() {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet7.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet7.Personel);
        }

        int secilenIndex;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenIndex = dataGridView1.SelectedCells[0].RowIndex;
            String personelID, personelAdSoyad, personelDepartman;
            personelID= dataGridView1.Rows[secilenIndex].Cells[0].Value.ToString();
            personelAdSoyad= dataGridView1.Rows[secilenIndex].Cells[1].Value.ToString();
            personelDepartman= dataGridView1.Rows[secilenIndex].Cells[2].Value.ToString(); ;

            txtBox_prsID.Text = personelID;
            txtBox_prsAdSoyad.Text = personelAdSoyad;
            txtBox_prsDep.Text = personelDepartman;
        }
    }
}
