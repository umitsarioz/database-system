namespace YOSis
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Güncelle = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.txtBox_prsDep = new System.Windows.Forms.TextBox();
            this.lbl_personelDepartman = new System.Windows.Forms.Label();
            this.txtBox_prsAdSoyad = new System.Windows.Forms.TextBox();
            this.lbl_personelAdSoyad = new System.Windows.Forms.Label();
            this.txtBox_prsID = new System.Windows.Forms.TextBox();
            this.lbl_personelID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDepartmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet7 = new YOSis.YurtOtomasyonuDataSet7();
            this.personelTableAdapter = new YOSis.YurtOtomasyonuDataSet7TableAdapters.PersonelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Sil.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(287, 154);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(107, 33);
            this.btn_Sil.TabIndex = 5;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Güncelle
            // 
            this.btn_Güncelle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Güncelle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Güncelle.Location = new System.Drawing.Point(174, 154);
            this.btn_Güncelle.Name = "btn_Güncelle";
            this.btn_Güncelle.Size = new System.Drawing.Size(107, 33);
            this.btn_Güncelle.TabIndex = 4;
            this.btn_Güncelle.Text = "Güncelle";
            this.btn_Güncelle.UseVisualStyleBackColor = false;
            this.btn_Güncelle.Click += new System.EventHandler(this.btn_Güncelle_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Kaydet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(61, 154);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(107, 33);
            this.btn_Kaydet.TabIndex = 3;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // txtBox_prsDep
            // 
            this.txtBox_prsDep.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_prsDep.Location = new System.Drawing.Point(174, 92);
            this.txtBox_prsDep.Name = "txtBox_prsDep";
            this.txtBox_prsDep.Size = new System.Drawing.Size(203, 30);
            this.txtBox_prsDep.TabIndex = 2;
            // 
            // lbl_personelDepartman
            // 
            this.lbl_personelDepartman.AutoSize = true;
            this.lbl_personelDepartman.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_personelDepartman.Location = new System.Drawing.Point(51, 97);
            this.lbl_personelDepartman.Name = "lbl_personelDepartman";
            this.lbl_personelDepartman.Size = new System.Drawing.Size(113, 23);
            this.lbl_personelDepartman.TabIndex = 13;
            this.lbl_personelDepartman.Text = "Departman:";
            // 
            // txtBox_prsAdSoyad
            // 
            this.txtBox_prsAdSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_prsAdSoyad.Location = new System.Drawing.Point(174, 56);
            this.txtBox_prsAdSoyad.Name = "txtBox_prsAdSoyad";
            this.txtBox_prsAdSoyad.Size = new System.Drawing.Size(203, 30);
            this.txtBox_prsAdSoyad.TabIndex = 1;
            // 
            // lbl_personelAdSoyad
            // 
            this.lbl_personelAdSoyad.AutoSize = true;
            this.lbl_personelAdSoyad.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_personelAdSoyad.Location = new System.Drawing.Point(41, 61);
            this.lbl_personelAdSoyad.Name = "lbl_personelAdSoyad";
            this.lbl_personelAdSoyad.Size = new System.Drawing.Size(123, 23);
            this.lbl_personelAdSoyad.TabIndex = 11;
            this.lbl_personelAdSoyad.Text = "Personel Adı:";
            // 
            // txtBox_prsID
            // 
            this.txtBox_prsID.Enabled = false;
            this.txtBox_prsID.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_prsID.Location = new System.Drawing.Point(174, 20);
            this.txtBox_prsID.Name = "txtBox_prsID";
            this.txtBox_prsID.Size = new System.Drawing.Size(203, 30);
            this.txtBox_prsID.TabIndex = 10;
            // 
            // lbl_personelID
            // 
            this.lbl_personelID.AutoSize = true;
            this.lbl_personelID.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_personelID.Location = new System.Drawing.Point(50, 25);
            this.lbl_personelID.Name = "lbl_personelID";
            this.lbl_personelID.Size = new System.Drawing.Size(114, 23);
            this.lbl_personelID.TabIndex = 9;
            this.lbl_personelID.Text = "Personel ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelIDDataGridViewTextBoxColumn,
            this.personalAdSoyadDataGridViewTextBoxColumn,
            this.personelDepartmanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(454, 217);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // personalAdSoyadDataGridViewTextBoxColumn
            // 
            this.personalAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonalAdSoyad";
            this.personalAdSoyadDataGridViewTextBoxColumn.HeaderText = "PersonalAdSoyad";
            this.personalAdSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personalAdSoyadDataGridViewTextBoxColumn.Name = "personalAdSoyadDataGridViewTextBoxColumn";
            this.personalAdSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelDepartmanDataGridViewTextBoxColumn
            // 
            this.personelDepartmanDataGridViewTextBoxColumn.DataPropertyName = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.HeaderText = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelDepartmanDataGridViewTextBoxColumn.Name = "personelDepartmanDataGridViewTextBoxColumn";
            this.personelDepartmanDataGridViewTextBoxColumn.Width = 150;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.yurtOtomasyonuDataSet7;
            // 
            // yurtOtomasyonuDataSet7
            // 
            this.yurtOtomasyonuDataSet7.DataSetName = "YurtOtomasyonuDataSet7";
            this.yurtOtomasyonuDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 408);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Güncelle);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txtBox_prsDep);
            this.Controls.Add(this.lbl_personelDepartman);
            this.Controls.Add(this.txtBox_prsAdSoyad);
            this.Controls.Add(this.lbl_personelAdSoyad);
            this.Controls.Add(this.txtBox_prsID);
            this.Controls.Add(this.lbl_personelID);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPersonel";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Güncelle;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.TextBox txtBox_prsDep;
        private System.Windows.Forms.Label lbl_personelDepartman;
        private System.Windows.Forms.TextBox txtBox_prsAdSoyad;
        private System.Windows.Forms.Label lbl_personelAdSoyad;
        private System.Windows.Forms.TextBox txtBox_prsID;
        private System.Windows.Forms.Label lbl_personelID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet7 yurtOtomasyonuDataSet7;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private YurtOtomasyonuDataSet7TableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDepartmanDataGridViewTextBoxColumn;
    }
}