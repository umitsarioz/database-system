namespace YOSis
{
    partial class FrmOgrDuzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrDuzenle));
            this.lbl_OgrID = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.grBox_veliBilgileri = new System.Windows.Forms.GroupBox();
            this.lbl_VeliAdSoyad = new System.Windows.Forms.Label();
            this.rcTBox_veliAdres = new System.Windows.Forms.RichTextBox();
            this.txtBox_veliAdSoyad = new System.Windows.Forms.TextBox();
            this.lbl_veliAdres = new System.Windows.Forms.Label();
            this.lbl_veliTelefon = new System.Windows.Forms.Label();
            this.mskTBox_veliTelefon = new System.Windows.Forms.MaskedTextBox();
            this.grBox_ogrBilgileri = new System.Windows.Forms.GroupBox();
            this.txtBox_ogrID = new System.Windows.Forms.TextBox();
            this.txtBox_OgrAdi = new System.Windows.Forms.TextBox();
            this.cmBox_ogrOdaNo = new System.Windows.Forms.ComboBox();
            this.cmBox_ogrBolum = new System.Windows.Forms.ComboBox();
            this.lbl_ogrTC = new System.Windows.Forms.Label();
            this.lbl_ogrAdi = new System.Windows.Forms.Label();
            this.mskTBox_ogrTC = new System.Windows.Forms.MaskedTextBox();
            this.lbl_ogrDogum = new System.Windows.Forms.Label();
            this.lbl_ogrMail = new System.Windows.Forms.Label();
            this.lbl_ogrOdaNo = new System.Windows.Forms.Label();
            this.lbl_ogrBolum = new System.Windows.Forms.Label();
            this.mskTBox_ogrTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lbl_ogrSoyad = new System.Windows.Forms.Label();
            this.txtBox_ogrSoyad = new System.Windows.Forms.TextBox();
            this.lbl_ogrTelefon = new System.Windows.Forms.Label();
            this.mskTBox_ogrDogum = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_ogrMail = new System.Windows.Forms.TextBox();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.grBox_veliBilgileri.SuspendLayout();
            this.grBox_ogrBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_OgrID
            // 
            this.lbl_OgrID.AutoSize = true;
            this.lbl_OgrID.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_OgrID.Location = new System.Drawing.Point(104, 33);
            this.lbl_OgrID.Name = "lbl_OgrID";
            this.lbl_OgrID.Size = new System.Drawing.Size(42, 23);
            this.lbl_OgrID.TabIndex = 25;
            this.lbl_OgrID.Text = "ID :";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Kaydet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(75, 616);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(165, 44);
            this.btn_Kaydet.TabIndex = 12;
            this.btn_Kaydet.Text = "Güncelle";
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // grBox_veliBilgileri
            // 
            this.grBox_veliBilgileri.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grBox_veliBilgileri.Controls.Add(this.lbl_VeliAdSoyad);
            this.grBox_veliBilgileri.Controls.Add(this.rcTBox_veliAdres);
            this.grBox_veliBilgileri.Controls.Add(this.txtBox_veliAdSoyad);
            this.grBox_veliBilgileri.Controls.Add(this.lbl_veliAdres);
            this.grBox_veliBilgileri.Controls.Add(this.lbl_veliTelefon);
            this.grBox_veliBilgileri.Controls.Add(this.mskTBox_veliTelefon);
            this.grBox_veliBilgileri.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grBox_veliBilgileri.Location = new System.Drawing.Point(22, 377);
            this.grBox_veliBilgileri.Name = "grBox_veliBilgileri";
            this.grBox_veliBilgileri.Size = new System.Drawing.Size(424, 233);
            this.grBox_veliBilgileri.TabIndex = 23;
            this.grBox_veliBilgileri.TabStop = false;
            this.grBox_veliBilgileri.Text = "Veli Bilgileri";
            // 
            // lbl_VeliAdSoyad
            // 
            this.lbl_VeliAdSoyad.AutoSize = true;
            this.lbl_VeliAdSoyad.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_VeliAdSoyad.Location = new System.Drawing.Point(49, 38);
            this.lbl_VeliAdSoyad.Name = "lbl_VeliAdSoyad";
            this.lbl_VeliAdSoyad.Size = new System.Drawing.Size(101, 23);
            this.lbl_VeliAdSoyad.TabIndex = 16;
            this.lbl_VeliAdSoyad.Text = "Ad Soyad :";
            // 
            // rcTBox_veliAdres
            // 
            this.rcTBox_veliAdres.BackColor = System.Drawing.SystemColors.Info;
            this.rcTBox_veliAdres.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rcTBox_veliAdres.Location = new System.Drawing.Point(158, 103);
            this.rcTBox_veliAdres.Name = "rcTBox_veliAdres";
            this.rcTBox_veliAdres.Size = new System.Drawing.Size(240, 112);
            this.rcTBox_veliAdres.TabIndex = 11;
            this.rcTBox_veliAdres.Text = "";
            // 
            // txtBox_veliAdSoyad
            // 
            this.txtBox_veliAdSoyad.BackColor = System.Drawing.SystemColors.Info;
            this.txtBox_veliAdSoyad.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_veliAdSoyad.Location = new System.Drawing.Point(157, 35);
            this.txtBox_veliAdSoyad.Name = "txtBox_veliAdSoyad";
            this.txtBox_veliAdSoyad.Size = new System.Drawing.Size(241, 28);
            this.txtBox_veliAdSoyad.TabIndex = 9;
            // 
            // lbl_veliAdres
            // 
            this.lbl_veliAdres.AutoSize = true;
            this.lbl_veliAdres.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_veliAdres.Location = new System.Drawing.Point(78, 106);
            this.lbl_veliAdres.Name = "lbl_veliAdres";
            this.lbl_veliAdres.Size = new System.Drawing.Size(70, 23);
            this.lbl_veliAdres.TabIndex = 16;
            this.lbl_veliAdres.Text = "Adres :";
            // 
            // lbl_veliTelefon
            // 
            this.lbl_veliTelefon.AutoSize = true;
            this.lbl_veliTelefon.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_veliTelefon.Location = new System.Drawing.Point(67, 72);
            this.lbl_veliTelefon.Name = "lbl_veliTelefon";
            this.lbl_veliTelefon.Size = new System.Drawing.Size(83, 23);
            this.lbl_veliTelefon.TabIndex = 16;
            this.lbl_veliTelefon.Text = "Telefon :";
            // 
            // mskTBox_veliTelefon
            // 
            this.mskTBox_veliTelefon.BackColor = System.Drawing.SystemColors.Info;
            this.mskTBox_veliTelefon.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTBox_veliTelefon.Location = new System.Drawing.Point(156, 69);
            this.mskTBox_veliTelefon.Mask = "(999) 000-0000";
            this.mskTBox_veliTelefon.Name = "mskTBox_veliTelefon";
            this.mskTBox_veliTelefon.Size = new System.Drawing.Size(241, 28);
            this.mskTBox_veliTelefon.TabIndex = 10;
            // 
            // grBox_ogrBilgileri
            // 
            this.grBox_ogrBilgileri.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grBox_ogrBilgileri.Controls.Add(this.lbl_OgrID);
            this.grBox_ogrBilgileri.Controls.Add(this.txtBox_ogrID);
            this.grBox_ogrBilgileri.Controls.Add(this.txtBox_OgrAdi);
            this.grBox_ogrBilgileri.Controls.Add(this.cmBox_ogrOdaNo);
            this.grBox_ogrBilgileri.Controls.Add(this.cmBox_ogrBolum);
            this.grBox_ogrBilgileri.Controls.Add(this.lbl_ogrTC);
            this.grBox_ogrBilgileri.Controls.Add(this.lbl_ogrAdi);
            this.grBox_ogrBilgileri.Controls.Add(this.mskTBox_ogrTC);
            this.grBox_ogrBilgileri.Controls.Add(this.lbl_ogrDogum);
            this.grBox_ogrBilgileri.Controls.Add(this.lbl_ogrMail);
            this.grBox_ogrBilgileri.Controls.Add(this.lbl_ogrOdaNo);
            this.grBox_ogrBilgileri.Controls.Add(this.lbl_ogrBolum);
            this.grBox_ogrBilgileri.Controls.Add(this.mskTBox_ogrTelefon);
            this.grBox_ogrBilgileri.Controls.Add(this.lbl_ogrSoyad);
            this.grBox_ogrBilgileri.Controls.Add(this.txtBox_ogrSoyad);
            this.grBox_ogrBilgileri.Controls.Add(this.lbl_ogrTelefon);
            this.grBox_ogrBilgileri.Controls.Add(this.mskTBox_ogrDogum);
            this.grBox_ogrBilgileri.Controls.Add(this.txtBox_ogrMail);
            this.grBox_ogrBilgileri.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grBox_ogrBilgileri.Location = new System.Drawing.Point(22, 28);
            this.grBox_ogrBilgileri.Name = "grBox_ogrBilgileri";
            this.grBox_ogrBilgileri.Size = new System.Drawing.Size(424, 343);
            this.grBox_ogrBilgileri.TabIndex = 22;
            this.grBox_ogrBilgileri.TabStop = false;
            this.grBox_ogrBilgileri.Text = "Öğrenci Bilgileri";
            // 
            // txtBox_ogrID
            // 
            this.txtBox_ogrID.BackColor = System.Drawing.SystemColors.Info;
            this.txtBox_ogrID.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_ogrID.Location = new System.Drawing.Point(154, 30);
            this.txtBox_ogrID.Name = "txtBox_ogrID";
            this.txtBox_ogrID.Size = new System.Drawing.Size(241, 28);
            this.txtBox_ogrID.TabIndex = 16;
            // 
            // txtBox_OgrAdi
            // 
            this.txtBox_OgrAdi.BackColor = System.Drawing.SystemColors.Info;
            this.txtBox_OgrAdi.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_OgrAdi.Location = new System.Drawing.Point(154, 64);
            this.txtBox_OgrAdi.Name = "txtBox_OgrAdi";
            this.txtBox_OgrAdi.Size = new System.Drawing.Size(241, 28);
            this.txtBox_OgrAdi.TabIndex = 1;
            // 
            // cmBox_ogrOdaNo
            // 
            this.cmBox_ogrOdaNo.BackColor = System.Drawing.SystemColors.Info;
            this.cmBox_ogrOdaNo.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmBox_ogrOdaNo.FormattingEnabled = true;
            this.cmBox_ogrOdaNo.Location = new System.Drawing.Point(155, 303);
            this.cmBox_ogrOdaNo.Name = "cmBox_ogrOdaNo";
            this.cmBox_ogrOdaNo.Size = new System.Drawing.Size(241, 29);
            this.cmBox_ogrOdaNo.TabIndex = 8;
            // 
            // cmBox_ogrBolum
            // 
            this.cmBox_ogrBolum.BackColor = System.Drawing.SystemColors.Info;
            this.cmBox_ogrBolum.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmBox_ogrBolum.FormattingEnabled = true;
            this.cmBox_ogrBolum.Location = new System.Drawing.Point(154, 234);
            this.cmBox_ogrBolum.Name = "cmBox_ogrBolum";
            this.cmBox_ogrBolum.Size = new System.Drawing.Size(241, 29);
            this.cmBox_ogrBolum.TabIndex = 6;
            // 
            // lbl_ogrTC
            // 
            this.lbl_ogrTC.AutoSize = true;
            this.lbl_ogrTC.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ogrTC.Location = new System.Drawing.Point(103, 135);
            this.lbl_ogrTC.Name = "lbl_ogrTC";
            this.lbl_ogrTC.Size = new System.Drawing.Size(45, 23);
            this.lbl_ogrTC.TabIndex = 4;
            this.lbl_ogrTC.Text = "TC :";
            // 
            // lbl_ogrAdi
            // 
            this.lbl_ogrAdi.AutoSize = true;
            this.lbl_ogrAdi.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ogrAdi.Location = new System.Drawing.Point(89, 67);
            this.lbl_ogrAdi.Name = "lbl_ogrAdi";
            this.lbl_ogrAdi.Size = new System.Drawing.Size(59, 23);
            this.lbl_ogrAdi.TabIndex = 1;
            this.lbl_ogrAdi.Text = "İsim :";
            // 
            // mskTBox_ogrTC
            // 
            this.mskTBox_ogrTC.BackColor = System.Drawing.SystemColors.Info;
            this.mskTBox_ogrTC.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTBox_ogrTC.Location = new System.Drawing.Point(154, 132);
            this.mskTBox_ogrTC.Mask = "00000000000";
            this.mskTBox_ogrTC.Name = "mskTBox_ogrTC";
            this.mskTBox_ogrTC.Size = new System.Drawing.Size(241, 28);
            this.mskTBox_ogrTC.TabIndex = 3;
            this.mskTBox_ogrTC.ValidatingType = typeof(int);
            // 
            // lbl_ogrDogum
            // 
            this.lbl_ogrDogum.AutoSize = true;
            this.lbl_ogrDogum.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ogrDogum.Location = new System.Drawing.Point(7, 203);
            this.lbl_ogrDogum.Name = "lbl_ogrDogum";
            this.lbl_ogrDogum.Size = new System.Drawing.Size(141, 23);
            this.lbl_ogrDogum.TabIndex = 8;
            this.lbl_ogrDogum.Text = "Doğum Tarihi :";
            // 
            // lbl_ogrMail
            // 
            this.lbl_ogrMail.AutoSize = true;
            this.lbl_ogrMail.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ogrMail.Location = new System.Drawing.Point(86, 272);
            this.lbl_ogrMail.Name = "lbl_ogrMail";
            this.lbl_ogrMail.Size = new System.Drawing.Size(60, 23);
            this.lbl_ogrMail.TabIndex = 12;
            this.lbl_ogrMail.Text = "Mail :";
            // 
            // lbl_ogrOdaNo
            // 
            this.lbl_ogrOdaNo.AutoSize = true;
            this.lbl_ogrOdaNo.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ogrOdaNo.Location = new System.Drawing.Point(62, 306);
            this.lbl_ogrOdaNo.Name = "lbl_ogrOdaNo";
            this.lbl_ogrOdaNo.Size = new System.Drawing.Size(86, 23);
            this.lbl_ogrOdaNo.TabIndex = 14;
            this.lbl_ogrOdaNo.Text = "Oda No :";
            // 
            // lbl_ogrBolum
            // 
            this.lbl_ogrBolum.AutoSize = true;
            this.lbl_ogrBolum.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ogrBolum.Location = new System.Drawing.Point(72, 237);
            this.lbl_ogrBolum.Name = "lbl_ogrBolum";
            this.lbl_ogrBolum.Size = new System.Drawing.Size(76, 23);
            this.lbl_ogrBolum.TabIndex = 10;
            this.lbl_ogrBolum.Text = "Bölüm :";
            // 
            // mskTBox_ogrTelefon
            // 
            this.mskTBox_ogrTelefon.BackColor = System.Drawing.SystemColors.Info;
            this.mskTBox_ogrTelefon.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTBox_ogrTelefon.Location = new System.Drawing.Point(154, 166);
            this.mskTBox_ogrTelefon.Mask = "(999) 000-0000";
            this.mskTBox_ogrTelefon.Name = "mskTBox_ogrTelefon";
            this.mskTBox_ogrTelefon.Size = new System.Drawing.Size(241, 28);
            this.mskTBox_ogrTelefon.TabIndex = 4;
            // 
            // lbl_ogrSoyad
            // 
            this.lbl_ogrSoyad.AutoSize = true;
            this.lbl_ogrSoyad.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ogrSoyad.Location = new System.Drawing.Point(76, 101);
            this.lbl_ogrSoyad.Name = "lbl_ogrSoyad";
            this.lbl_ogrSoyad.Size = new System.Drawing.Size(72, 23);
            this.lbl_ogrSoyad.TabIndex = 3;
            this.lbl_ogrSoyad.Text = "Soyad :";
            // 
            // txtBox_ogrSoyad
            // 
            this.txtBox_ogrSoyad.BackColor = System.Drawing.SystemColors.Info;
            this.txtBox_ogrSoyad.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_ogrSoyad.Location = new System.Drawing.Point(154, 98);
            this.txtBox_ogrSoyad.Name = "txtBox_ogrSoyad";
            this.txtBox_ogrSoyad.Size = new System.Drawing.Size(241, 28);
            this.txtBox_ogrSoyad.TabIndex = 2;
            // 
            // lbl_ogrTelefon
            // 
            this.lbl_ogrTelefon.AutoSize = true;
            this.lbl_ogrTelefon.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ogrTelefon.Location = new System.Drawing.Point(65, 169);
            this.lbl_ogrTelefon.Name = "lbl_ogrTelefon";
            this.lbl_ogrTelefon.Size = new System.Drawing.Size(83, 23);
            this.lbl_ogrTelefon.TabIndex = 6;
            this.lbl_ogrTelefon.Text = "Telefon :";
            // 
            // mskTBox_ogrDogum
            // 
            this.mskTBox_ogrDogum.BackColor = System.Drawing.SystemColors.Info;
            this.mskTBox_ogrDogum.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTBox_ogrDogum.Location = new System.Drawing.Point(154, 200);
            this.mskTBox_ogrDogum.Mask = "00/00/0000";
            this.mskTBox_ogrDogum.Name = "mskTBox_ogrDogum";
            this.mskTBox_ogrDogum.Size = new System.Drawing.Size(241, 28);
            this.mskTBox_ogrDogum.TabIndex = 5;
            this.mskTBox_ogrDogum.ValidatingType = typeof(System.DateTime);
            // 
            // txtBox_ogrMail
            // 
            this.txtBox_ogrMail.BackColor = System.Drawing.SystemColors.Info;
            this.txtBox_ogrMail.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_ogrMail.Location = new System.Drawing.Point(155, 269);
            this.txtBox_ogrMail.Name = "txtBox_ogrMail";
            this.txtBox_ogrMail.Size = new System.Drawing.Size(241, 28);
            this.txtBox_ogrMail.TabIndex = 7;
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Sil.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(255, 616);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(165, 44);
            this.btn_Sil.TabIndex = 13;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // FrmOgrDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(463, 663);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.grBox_veliBilgileri);
            this.Controls.Add(this.grBox_ogrBilgileri);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrDuzenle";
            this.Text = "Öğrenci Düzenle";
            this.Load += new System.EventHandler(this.FrmOgrDuzenle_Load);
            this.grBox_veliBilgileri.ResumeLayout(false);
            this.grBox_veliBilgileri.PerformLayout();
            this.grBox_ogrBilgileri.ResumeLayout(false);
            this.grBox_ogrBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_OgrID;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.GroupBox grBox_veliBilgileri;
        private System.Windows.Forms.Label lbl_VeliAdSoyad;
        private System.Windows.Forms.RichTextBox rcTBox_veliAdres;
        private System.Windows.Forms.TextBox txtBox_veliAdSoyad;
        private System.Windows.Forms.Label lbl_veliAdres;
        private System.Windows.Forms.Label lbl_veliTelefon;
        private System.Windows.Forms.MaskedTextBox mskTBox_veliTelefon;
        private System.Windows.Forms.GroupBox grBox_ogrBilgileri;
        private System.Windows.Forms.TextBox txtBox_ogrID;
        private System.Windows.Forms.TextBox txtBox_OgrAdi;
        private System.Windows.Forms.ComboBox cmBox_ogrOdaNo;
        private System.Windows.Forms.ComboBox cmBox_ogrBolum;
        private System.Windows.Forms.Label lbl_ogrTC;
        private System.Windows.Forms.Label lbl_ogrAdi;
        private System.Windows.Forms.MaskedTextBox mskTBox_ogrTC;
        private System.Windows.Forms.Label lbl_ogrDogum;
        private System.Windows.Forms.Label lbl_ogrMail;
        private System.Windows.Forms.Label lbl_ogrOdaNo;
        private System.Windows.Forms.Label lbl_ogrBolum;
        private System.Windows.Forms.MaskedTextBox mskTBox_ogrTelefon;
        private System.Windows.Forms.Label lbl_ogrSoyad;
        private System.Windows.Forms.TextBox txtBox_ogrSoyad;
        private System.Windows.Forms.Label lbl_ogrTelefon;
        private System.Windows.Forms.MaskedTextBox mskTBox_ogrDogum;
        private System.Windows.Forms.TextBox txtBox_ogrMail;
        private System.Windows.Forms.Button btn_Sil;
    }
}