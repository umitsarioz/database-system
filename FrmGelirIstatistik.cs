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
    public partial class FrmGelirIstatistik : Form
    {
        public FrmGelirIstatistik()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void gelirTopla() {
            SqlCommand komut = new SqlCommand("Select Sum(OdemeMiktar) From Kasa", bgl.baglanti()); // Sum Sql komutu, veriler arasında toplama işlemi yapar.
            SqlDataReader oku = komut.ExecuteReader(); // okuma işlemi gerçekleştirilir.

            while (oku.Read()) //okuma komutu çalıştığı sürece, okunanı gerçekleştir.
            {
                lbl_Gelir.Text ="Kasadaki Para: "+ oku[0].ToString()+" Türk Lirası";
            }
        }

        private void tekrarsizListele() {
            SqlCommand komut = new SqlCommand("Select distinct(OdemeAy) From Kasa",bgl.baglanti()); // Distinct sql komutu, aynı isimde olanları filtreleyerek tek olarak gözükmesini saglar.
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read()) {
                cmBox_Ay.Items.Add(oku[0].ToString());
            }

        }
        private void secilenAyTopla() { // Secilen Ay'a göre toplama işlemleri gerçekleştirilir.
            SqlCommand komut = new SqlCommand("Select Sum(OdemeMiktar) From Kasa where OdemeAy=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmBox_Ay.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read()){

                lbl_secilenAy.Text = oku[0].ToString();
            }
            
        }


        private void chartTopla() {
            SqlCommand komut = new SqlCommand("select OdemeAy,sum(OdemeMiktar) from Kasa group by OdemeAy",bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read()) {
                this.chart_aylik.Series["Aylık"].Points.AddXY(oku[0].ToString(),oku[1].ToString());
            }
        }
        private void FrmGelirIstatistik_Load(object sender, EventArgs e)
        {
            try
            {
                gelirTopla();
                tekrarsizListele();
                chartTopla();
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

        private void cmBox_Ay_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenAyTopla();
        }
    }
    }

