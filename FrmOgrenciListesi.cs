using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YOSis
{
    public partial class FrmOgrenciListesi : Form
    {
        public FrmOgrenciListesi()
        {
            InitializeComponent();
        }

        public void ogrListesiniDoldur() {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet3.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet3.Ogrenci);

        }
        private void FrmOgrenciListesi_Load(object sender, EventArgs e)
        {
            ogrListesiniDoldur();

        }
        int secilen; // secilen satırı belirtir.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bilgileri güncelleme formuna yerleştirir.
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmOgrDuzenle fr = new FrmOgrDuzenle();
            fr.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.TC = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.dogum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.bolum = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.mail = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.odaNo = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            fr.VeliAdSoyad = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            fr.VeliTel = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            fr.VeliAdres = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            fr.Show();
        }
    }
}
