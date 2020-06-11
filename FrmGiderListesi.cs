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
    public partial class FrmGiderListesi : Form
    {
        public FrmGiderListesi()
        {
            InitializeComponent();
        }

        private void FrmGiderListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet4.Giderler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.giderlerTableAdapter.Fill(this.yurtOtomasyonuDataSet4.Giderler);

        }

        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmGiderGuncelle fr = new FrmGiderGuncelle(); // Form guncelleme nesnesi olusturdum.
            secilen = dataGridView1.SelectedCells[0].RowIndex; // secilen indexin satırını aldım.
         

            fr.GiderID = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.Elektrik = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.Su = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.Dogalgaz = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.internet = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.Gıda = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.Personel = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.Diger = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

            fr.Show(); // Diger Formu göster ! .

        }
    }
}
