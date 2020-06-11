namespace YOSis
{
    partial class FrmOdemeler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeler));
            this.lbl_ogrID = new System.Windows.Forms.Label();
            this.txtBox_ogrID = new System.Windows.Forms.TextBox();
            this.txtBox_odenecekTutar = new System.Windows.Forms.TextBox();
            this.lbl_odenecekTutar = new System.Windows.Forms.Label();
            this.txtBox_kalanBorc = new System.Windows.Forms.TextBox();
            this.lbl_kalanBorc = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.dGV_ogrBorc = new System.Windows.Forms.DataGridView();
            this.ogrIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrKalanBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet2 = new YOSis.YurtOtomasyonuDataSet2();
            this.yurtOtomasyonuDataSet = new YOSis.YurtOtomasyonuDataSet();
            this.yurtOtomasyonuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bolumlerTableAdapter = new YOSis.YurtOtomasyonuDataSetTableAdapters.BolumlerTableAdapter();
            this.borclarTableAdapter = new YOSis.YurtOtomasyonuDataSet2TableAdapters.BorclarTableAdapter();
            this.txtBox_ogrAd = new System.Windows.Forms.TextBox();
            this.lbl_ogrAd = new System.Windows.Forms.Label();
            this.txtBox_ogrSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_odenenAy = new System.Windows.Forms.TextBox();
            this.lbl_OdenenAy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ogrBorc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ogrID
            // 
            this.lbl_ogrID.AutoSize = true;
            this.lbl_ogrID.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ogrID.Location = new System.Drawing.Point(62, 9);
            this.lbl_ogrID.Name = "lbl_ogrID";
            this.lbl_ogrID.Size = new System.Drawing.Size(129, 23);
            this.lbl_ogrID.TabIndex = 0;
            this.lbl_ogrID.Text = "Öğrenci ID :";
            // 
            // txtBox_ogrID
            // 
            this.txtBox_ogrID.Enabled = false;
            this.txtBox_ogrID.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_ogrID.Location = new System.Drawing.Point(197, 4);
            this.txtBox_ogrID.Name = "txtBox_ogrID";
            this.txtBox_ogrID.Size = new System.Drawing.Size(169, 30);
            this.txtBox_ogrID.TabIndex = 1;
            // 
            // txtBox_odenecekTutar
            // 
            this.txtBox_odenecekTutar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_odenecekTutar.Location = new System.Drawing.Point(197, 112);
            this.txtBox_odenecekTutar.Name = "txtBox_odenecekTutar";
            this.txtBox_odenecekTutar.Size = new System.Drawing.Size(169, 30);
            this.txtBox_odenecekTutar.TabIndex = 3;
            // 
            // lbl_odenecekTutar
            // 
            this.lbl_odenecekTutar.AutoSize = true;
            this.lbl_odenecekTutar.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_odenecekTutar.Location = new System.Drawing.Point(12, 117);
            this.lbl_odenecekTutar.Name = "lbl_odenecekTutar";
            this.lbl_odenecekTutar.Size = new System.Drawing.Size(179, 23);
            this.lbl_odenecekTutar.TabIndex = 2;
            this.lbl_odenecekTutar.Text = "Ödenecek Tutar :";
            // 
            // txtBox_kalanBorc
            // 
            this.txtBox_kalanBorc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_kalanBorc.Location = new System.Drawing.Point(197, 148);
            this.txtBox_kalanBorc.Name = "txtBox_kalanBorc";
            this.txtBox_kalanBorc.Size = new System.Drawing.Size(169, 30);
            this.txtBox_kalanBorc.TabIndex = 4;
            // 
            // lbl_kalanBorc
            // 
            this.lbl_kalanBorc.AutoSize = true;
            this.lbl_kalanBorc.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kalanBorc.Location = new System.Drawing.Point(60, 153);
            this.lbl_kalanBorc.Name = "lbl_kalanBorc";
            this.lbl_kalanBorc.Size = new System.Drawing.Size(131, 23);
            this.lbl_kalanBorc.TabIndex = 4;
            this.lbl_kalanBorc.Text = "Kalan Borç :";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(197, 220);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(166, 41);
            this.btn_kaydet.TabIndex = 6;
            this.btn_kaydet.Text = "Ödeme Al";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // dGV_ogrBorc
            // 
            this.dGV_ogrBorc.AutoGenerateColumns = false;
            this.dGV_ogrBorc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ogrBorc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrIDDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrKalanBorcDataGridViewTextBoxColumn});
            this.dGV_ogrBorc.DataSource = this.borclarBindingSource;
            this.dGV_ogrBorc.Location = new System.Drawing.Point(388, 1);
            this.dGV_ogrBorc.Name = "dGV_ogrBorc";
            this.dGV_ogrBorc.RowHeadersWidth = 51;
            this.dGV_ogrBorc.RowTemplate.Height = 24;
            this.dGV_ogrBorc.Size = new System.Drawing.Size(552, 260);
            this.dGV_ogrBorc.TabIndex = 7;
            this.dGV_ogrBorc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogrIDDataGridViewTextBoxColumn
            // 
            this.ogrIDDataGridViewTextBoxColumn.DataPropertyName = "OgrID";
            this.ogrIDDataGridViewTextBoxColumn.HeaderText = "OgrID";
            this.ogrIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrIDDataGridViewTextBoxColumn.Name = "ogrIDDataGridViewTextBoxColumn";
            this.ogrIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            this.ogrAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            this.ogrSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrKalanBorcDataGridViewTextBoxColumn
            // 
            this.ogrKalanBorcDataGridViewTextBoxColumn.DataPropertyName = "OgrKalanBorc";
            this.ogrKalanBorcDataGridViewTextBoxColumn.HeaderText = "OgrKalanBorc";
            this.ogrKalanBorcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrKalanBorcDataGridViewTextBoxColumn.Name = "ogrKalanBorcDataGridViewTextBoxColumn";
            this.ogrKalanBorcDataGridViewTextBoxColumn.Width = 125;
            // 
            // borclarBindingSource
            // 
            this.borclarBindingSource.DataMember = "Borclar";
            this.borclarBindingSource.DataSource = this.yurtOtomasyonuDataSet2;
            // 
            // yurtOtomasyonuDataSet2
            // 
            this.yurtOtomasyonuDataSet2.DataSetName = "YurtOtomasyonuDataSet2";
            this.yurtOtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yurtOtomasyonuDataSet
            // 
            this.yurtOtomasyonuDataSet.DataSetName = "YurtOtomasyonuDataSet";
            this.yurtOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yurtOtomasyonuDataSetBindingSource
            // 
            this.yurtOtomasyonuDataSetBindingSource.DataSource = this.yurtOtomasyonuDataSet;
            this.yurtOtomasyonuDataSetBindingSource.Position = 0;
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtOtomasyonuDataSetBindingSource;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // borclarTableAdapter
            // 
            this.borclarTableAdapter.ClearBeforeFill = true;
            // 
            // txtBox_ogrAd
            // 
            this.txtBox_ogrAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_ogrAd.Location = new System.Drawing.Point(197, 40);
            this.txtBox_ogrAd.Name = "txtBox_ogrAd";
            this.txtBox_ogrAd.Size = new System.Drawing.Size(169, 30);
            this.txtBox_ogrAd.TabIndex = 1;
            // 
            // lbl_ogrAd
            // 
            this.lbl_ogrAd.AutoSize = true;
            this.lbl_ogrAd.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ogrAd.Location = new System.Drawing.Point(142, 47);
            this.lbl_ogrAd.Name = "lbl_ogrAd";
            this.lbl_ogrAd.Size = new System.Drawing.Size(49, 23);
            this.lbl_ogrAd.TabIndex = 8;
            this.lbl_ogrAd.Text = "Ad :";
            // 
            // txtBox_ogrSoyad
            // 
            this.txtBox_ogrSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_ogrSoyad.Location = new System.Drawing.Point(197, 76);
            this.txtBox_ogrSoyad.Name = "txtBox_ogrSoyad";
            this.txtBox_ogrSoyad.Size = new System.Drawing.Size(169, 30);
            this.txtBox_ogrSoyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(110, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Soyad :";
            // 
            // txtBox_odenenAy
            // 
            this.txtBox_odenenAy.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_odenenAy.Location = new System.Drawing.Point(197, 184);
            this.txtBox_odenenAy.Name = "txtBox_odenenAy";
            this.txtBox_odenenAy.Size = new System.Drawing.Size(169, 30);
            this.txtBox_odenenAy.TabIndex = 5;
            // 
            // lbl_OdenenAy
            // 
            this.lbl_OdenenAy.AutoSize = true;
            this.lbl_OdenenAy.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_OdenenAy.Location = new System.Drawing.Point(60, 189);
            this.lbl_OdenenAy.Name = "lbl_OdenenAy";
            this.lbl_OdenenAy.Size = new System.Drawing.Size(129, 23);
            this.lbl_OdenenAy.TabIndex = 12;
            this.lbl_OdenenAy.Text = "Ödenen Ay :";
            // 
            // FrmOdemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(941, 265);
            this.Controls.Add(this.txtBox_odenenAy);
            this.Controls.Add(this.lbl_OdenenAy);
            this.Controls.Add(this.txtBox_ogrSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_ogrAd);
            this.Controls.Add(this.lbl_ogrAd);
            this.Controls.Add(this.dGV_ogrBorc);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txtBox_kalanBorc);
            this.Controls.Add(this.lbl_kalanBorc);
            this.Controls.Add(this.txtBox_odenecekTutar);
            this.Controls.Add(this.lbl_odenecekTutar);
            this.Controls.Add(this.txtBox_ogrID);
            this.Controls.Add(this.lbl_ogrID);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOdemeler";
            this.Text = "Ödemeler";
            this.Load += new System.EventHandler(this.FrmOdemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ogrBorc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ogrID;
        private System.Windows.Forms.TextBox txtBox_ogrID;
        private System.Windows.Forms.TextBox txtBox_odenecekTutar;
        private System.Windows.Forms.Label lbl_odenecekTutar;
        private System.Windows.Forms.TextBox txtBox_kalanBorc;
        private System.Windows.Forms.Label lbl_kalanBorc;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.DataGridView dGV_ogrBorc;
        private System.Windows.Forms.BindingSource yurtOtomasyonuDataSetBindingSource;
        private YurtOtomasyonuDataSet yurtOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private YurtOtomasyonuDataSetTableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private YurtOtomasyonuDataSet2 yurtOtomasyonuDataSet2;
        private System.Windows.Forms.BindingSource borclarBindingSource;
        private YurtOtomasyonuDataSet2TableAdapters.BorclarTableAdapter borclarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrKalanBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtBox_ogrAd;
        private System.Windows.Forms.Label lbl_ogrAd;
        private System.Windows.Forms.TextBox txtBox_ogrSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_odenenAy;
        private System.Windows.Forms.Label lbl_OdenenAy;
    }
}