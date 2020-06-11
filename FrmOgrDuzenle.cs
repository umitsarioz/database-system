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
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        FrmOgrKayit ogrKayit = new FrmOgrKayit(); // Bölümleri ve odaları almak için olusturulan nesne.
        

        public string id, ad, soyad, TC;
        public string telefon, dogum, bolum, mail;

        private void odaKontenjaniAzaltma()
        {

            SqlCommand komut = new SqlCommand("update Odalar set OdaAktif=OdaAktif-1 where OdaNo=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmBox_ogrOdaNo.Text);
            komut.ExecuteNonQuery();
        }

        private void ogrenciSil() {
            SqlCommand komut = new SqlCommand("delete from Ogrenci where OgrID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBox_ogrID.Text);
            komut.ExecuteNonQuery();

        }
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                ogrenciSil();
                odaKontenjaniAzaltma();
                MessageBox.Show("Ogrenci Silindi.");
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!!");
            }
            finally {
                bgl.baglanti().Close();
            }
        }

        public string odaNo, VeliAdSoyad, VeliTel, VeliAdres;

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p2,OgrSoyad=@p3,OgrTC=@p4,OgrTelefon=@p5,OgrDogum=@p6,OgrBolum=@p7,OgrMail=@p8,OgrOdaNo=@p9,OgrVeliAdSoyad=@p10,OgrVeliTelefon=@p11,OgrVeliAdres=@p12 where OgrID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtBox_ogrID.Text);
                komut.Parameters.AddWithValue("@p2", txtBox_OgrAdi.Text);
                komut.Parameters.AddWithValue("@p3", txtBox_ogrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", mskTBox_ogrTC.Text);
                komut.Parameters.AddWithValue("@p5", mskTBox_ogrTelefon.Text);
                komut.Parameters.AddWithValue("@p6", mskTBox_ogrDogum.Text);
                komut.Parameters.AddWithValue("@p7", cmBox_ogrBolum.Text);
                komut.Parameters.AddWithValue("@p8", txtBox_ogrMail.Text);
                komut.Parameters.AddWithValue("@p9", cmBox_ogrOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", txtBox_veliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p11", mskTBox_veliTelefon.Text);
                komut.Parameters.AddWithValue("@p12", rcTBox_veliAdres.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Güncelleme Başarılı!!");
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

        
        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {

            
            ogrKayit.bolumleriListele(); // Bölümleri alan fonksiyon. 
            ogrKayit.odalariListele(); // Odaları alan fonksiyon.

            txtBox_ogrID.Text = id;
            txtBox_OgrAdi.Text = ad;
            txtBox_ogrSoyad.Text = soyad;
            mskTBox_ogrTC.Text = TC;
            mskTBox_ogrTelefon.Text = telefon;
            mskTBox_ogrDogum.Text = dogum;
            cmBox_ogrBolum.Text = bolum;
            txtBox_ogrMail.Text = mail;
            cmBox_ogrOdaNo.Text = odaNo;
            txtBox_veliAdSoyad.Text = VeliAdSoyad;
            mskTBox_veliTelefon.Text = VeliTel;
            rcTBox_veliAdres.Text = VeliAdres;


        }
    }
}
