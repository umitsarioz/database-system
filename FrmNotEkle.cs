using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YOSis
{
    public partial class FrmNotEkle : Form
    {
        public FrmNotEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Not Eklemek için gerekli komutlar.
            saveFileDialog1.Title = "Kayıt Yeri Seçiniz ";
            saveFileDialog1.Filter = "Metin Dosyası | *.txt";
            saveFileDialog1.InitialDirectory = "C:\\Notlar";
            saveFileDialog1.ShowDialog(); // IO kutuphanesini eklemeyi unutma . 

            StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);
            kaydet.WriteLine(richTextBox1.Text);
            kaydet.Close();

            MessageBox.Show("Kayıt Yapıldı.");
        }
    }
}
