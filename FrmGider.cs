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
    public partial class FrmGider : Form
    {
        public FrmGider()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand(" insert into Giderler(Elektrik,Su,Dogalgaz,internet,Gıda,Personel,Diger) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)",bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtBox_Elektrik.Text);
                komut.Parameters.AddWithValue("@p2", txtBox_Su.Text);
                komut.Parameters.AddWithValue("@p3", txtBox_DogalGaz.Text);
                komut.Parameters.AddWithValue("@p4", txtBox_internet.Text);
                komut.Parameters.AddWithValue("@p5", txtBox_Gıda.Text);
                komut.Parameters.AddWithValue("@p6", txtBox_Personel.Text);
                komut.Parameters.AddWithValue("@p7", txtBox_Diger.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı!!");
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!!");
            }
            finally {
                bgl.baglanti().Close();
            }

        }
    }
}
