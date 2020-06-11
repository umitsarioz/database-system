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
    public partial class FrmAdminGirisi : Form
    {
        public FrmAdminGirisi()
        {
            InitializeComponent();
        }


        //private void manuelKontrol() {

        //    if (txtBox_id.Text == "admin" && txtBox_pw.Text == "sifre123*")
        //    {
        //        MessageBox.Show("Giriş Başarılı..");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Hatalı şifre veya kullanıcı adı girdiniz..");

        //    }
        //}
        SqlBaglantim bgl = new SqlBaglantim();
        private void btn_giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Admin where YoneticiAd=@p1 and YoneticiSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBox_id.Text);
            komut.Parameters.AddWithValue("@p2", txtBox_pw.Text);

            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Kullanıcı adı veya Şifre Hatalı!");
                txtBox_id.Clear();
                txtBox_pw.Clear();
                txtBox_id.Focus();
            }
            bgl.baglanti().Close();
        }

        private void btn_giris_KeyPress(object sender, KeyPressEventArgs e)
        {
            btn_giris_Click(sender,e);
        }
    }
}
