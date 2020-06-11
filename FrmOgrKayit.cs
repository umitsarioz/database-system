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
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();  // SQL Connection Baglantisi gerçekleştirildi.
        

        public void bolumleriListele() {
            

            // Bölümleri listeleme komutu
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", bgl.baglanti()); // sorguyu gerçekleştir ve baglanti degiskeniyle ilişkilendir.
            //Sorgu : bolumler listesindeki Bölümadlarını al.

            SqlDataReader oku = komut.ExecuteReader(); // komutu gerçekleştir.
            while (oku.Read()) // okuma gerçekleştiği sürece komutları gerçekleştir.
            {
                cmBox_ogrBolum.Items.Add(oku[0].ToString()); // okuduğunu stringe çevir ve belirtilen combobaxa ekle.
            }
            bgl.baglanti().Close(); //baglanti kapatıldı.

        } //Bolumleri listeleyen fonksiyon.

        public void odalariListele() {
          

            // Odaları listeleme komutu
            SqlCommand komut = new SqlCommand("Select OdaNo From Odalar where OdaKapasite != OdaAktif", bgl.baglanti()); // sorguyu gerçekleştir ve baglanti degiskeniyle ilişkilendir.
            // Sorgu : Odalar listesinden Odanumarasını getir ve bu oda kapasite ile oda aktif kalan kişiler eşit olmamalıdır.
            
            SqlDataReader oku = komut.ExecuteReader(); // komutu gerçekleştir.
            while (oku.Read()) // okuma gerçekleştiği sürece komutları gerçekleştir.
            {
                cmBox_ogrOdaNo.Items.Add(oku[0].ToString()); // okuduğunu stringe çevir ve belirtilen combobaxa ekle.
            }
            bgl.baglanti().Close(); //baglanti kapatıldı.

        } // Boş odaları listeleyen fonksiyon.

        public void ogrenciKaydet() {

            SqlCommand komut = new SqlCommand("insert into Ogrenci (OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBox_OgrAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtBox_ogrSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTBox_ogrTC.Text);
            komut.Parameters.AddWithValue("@p4", mskTBox_ogrTelefon.Text);
            komut.Parameters.AddWithValue("@p5", mskTBox_ogrDogum.Text);
            komut.Parameters.AddWithValue("@p6", cmBox_ogrBolum.Text);
            komut.Parameters.AddWithValue("@p7", txtBox_ogrMail.Text);
            komut.Parameters.AddWithValue("@p8", cmBox_ogrOdaNo.Text);
            komut.Parameters.AddWithValue("@p9", txtBox_veliAdSoyad.Text);
            komut.Parameters.AddWithValue("@p10", mskTBox_veliTelefon.Text);
            komut.Parameters.AddWithValue("@p11", rcTBox_veliAdres.Text);

            komut.ExecuteNonQuery();
        } // Ögrenci kaydını yapan fonksiyon.

        public void borclariKaydet() {

            // Ogrenci Id'sini alan Sql komutu.
            SqlCommand ogrIdAl = new SqlCommand("Select OgrID From Ogrenci",bgl.baglanti()); //Query.
            SqlDataReader oku = ogrIdAl.ExecuteReader();
            while (oku.Read()) {
                lbl_OgrID.Text = oku[0].ToString(); // Ogrenci Id'sini label'a aktardım.
            }
            bgl.baglanti().Close(); //Baglanti Kapatmayı Unutma ! 

            //Borclar tablosuna insert eden query.
            SqlCommand komut = new SqlCommand("insert into Borclar (OgrID,OgrAd,OgrSoyad) values (@p1,@p2,@p3) ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lbl_OgrID.Text);
            komut.Parameters.AddWithValue("@p2", txtBox_OgrAdi.Text);
            komut.Parameters.AddWithValue("@p3", txtBox_ogrSoyad.Text);
            komut.ExecuteNonQuery();
        } // Borçları kaydeden fonksiyon.
        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {
            // Form yüklendiği anda veri tabanı bağlantısı gerçekleştirilip gerekli veriler alınıyor.
            bolumleriListele();
            odalariListele();
            
        }

        private void odaKontenjaniArttirma() {

            SqlCommand komut = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNo=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmBox_ogrOdaNo.Text);
            komut.ExecuteNonQuery();
        }
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            
            try
            {
                ogrenciKaydet();
                odaKontenjaniArttirma();
                //Sorgular üzerindeki değişiklikleri gerçekleştiriyor.
                MessageBox.Show("Öğrenci Kaydı gerçekleştirildi..");
            }
            catch (Exception exception)
            {
                MessageBox.Show("HATA! !!! ÖĞRENCİ KAYDI BAŞARISIZ!!!");
            
            }
            finally
            {
                bgl.baglanti().Close();
            } // Öğrenci Kayıt.

            try
            {
                borclariKaydet();
                MessageBox.Show("Borç Kaydı Başarılı..");
            }
            catch (Exception)
            {

                MessageBox.Show("BORC KAYDINDA HATA!!");
            }
            finally
            {
                bgl.baglanti().Close();
            } // Borç Kayıt.

        }
    }
}
