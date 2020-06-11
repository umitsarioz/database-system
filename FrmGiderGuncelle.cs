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
    public partial class FrmGiderGuncelle : Form
    {
        public FrmGiderGuncelle()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        public string GiderID,Elektrik, Su, Dogalgaz, internet, Gıda, Personel, Diger;

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Giderler set Elektrik=@p2,Su=@p3,Dogalgaz=@p4,internet=@p5,Gıda=@p6,Personel=@p7,Diger=@p8 where OdemeID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtBox_GiderID.Text);
                komut.Parameters.AddWithValue("@p2", txtBox_Elektrik.Text);
                komut.Parameters.AddWithValue("@p3", txtBox_Su.Text);
                komut.Parameters.AddWithValue("@p4", txtBox_DogalGaz.Text);
                komut.Parameters.AddWithValue("@p5", txtBox_internet.Text);
                komut.Parameters.AddWithValue("@p6", txtBox_Gıda.Text);
                komut.Parameters.AddWithValue("@p7", txtBox_Personel.Text);
                komut.Parameters.AddWithValue("@p8", txtBox_Diger.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Güncelleme Başarılı..");
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!!");
            }
            finally {
                bgl.baglanti().Close();
            }

        }

        private void FrmGiderGuncelle_Load(object sender, EventArgs e)
        {
            // Tablodan verileri doldur.
            txtBox_GiderID.Text = GiderID;
            txtBox_Elektrik.Text = Elektrik;
            txtBox_Su.Text = Su;
            txtBox_DogalGaz.Text = Dogalgaz;
            txtBox_internet.Text = internet;
            txtBox_Gıda.Text = Gıda;
            txtBox_Personel.Text = Personel;
            txtBox_Diger.Text = Diger;
        }
    }
}
