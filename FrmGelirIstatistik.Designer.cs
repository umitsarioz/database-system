namespace YOSis
{
    partial class FrmGelirIstatistik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGelirIstatistik));
            this.lbl_Gelir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmBox_Ay = new System.Windows.Forms.ComboBox();
            this.lbl_saTutar = new System.Windows.Forms.Label();
            this.lbl_secilenAy = new System.Windows.Forms.Label();
            this.chart_aylik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_aylik)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Gelir
            // 
            this.lbl_Gelir.AutoSize = true;
            this.lbl_Gelir.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Gelir.Location = new System.Drawing.Point(374, 18);
            this.lbl_Gelir.Name = "lbl_Gelir";
            this.lbl_Gelir.Size = new System.Drawing.Size(144, 23);
            this.lbl_Gelir.TabIndex = 0;
            this.lbl_Gelir.Text = "Kasadaki Para :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ay Seçiniz : ";
            // 
            // cmBox_Ay
            // 
            this.cmBox_Ay.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmBox_Ay.FormattingEnabled = true;
            this.cmBox_Ay.Location = new System.Drawing.Point(145, 13);
            this.cmBox_Ay.Name = "cmBox_Ay";
            this.cmBox_Ay.Size = new System.Drawing.Size(178, 32);
            this.cmBox_Ay.TabIndex = 2;
            this.cmBox_Ay.SelectedIndexChanged += new System.EventHandler(this.cmBox_Ay_SelectedIndexChanged);
            // 
            // lbl_saTutar
            // 
            this.lbl_saTutar.AutoSize = true;
            this.lbl_saTutar.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saTutar.Location = new System.Drawing.Point(374, 62);
            this.lbl_saTutar.Name = "lbl_saTutar";
            this.lbl_saTutar.Size = new System.Drawing.Size(234, 23);
            this.lbl_saTutar.TabIndex = 3;
            this.lbl_saTutar.Text = "Secilen Ay\'ın Kasa Tutarı :";
            // 
            // lbl_secilenAy
            // 
            this.lbl_secilenAy.AutoSize = true;
            this.lbl_secilenAy.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_secilenAy.Location = new System.Drawing.Point(604, 62);
            this.lbl_secilenAy.Name = "lbl_secilenAy";
            this.lbl_secilenAy.Size = new System.Drawing.Size(22, 23);
            this.lbl_secilenAy.TabIndex = 4;
            this.lbl_secilenAy.Text = "0";
            // 
            // chart_aylik
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_aylik.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_aylik.Legends.Add(legend1);
            this.chart_aylik.Location = new System.Drawing.Point(12, 173);
            this.chart_aylik.Name = "chart_aylik";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Aylık";
            this.chart_aylik.Series.Add(series1);
            this.chart_aylik.Size = new System.Drawing.Size(716, 231);
            this.chart_aylik.TabIndex = 5;
            this.chart_aylik.Text = "chart1";
            // 
            // FrmGelirIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(740, 418);
            this.Controls.Add(this.chart_aylik);
            this.Controls.Add(this.lbl_secilenAy);
            this.Controls.Add(this.lbl_saTutar);
            this.Controls.Add(this.cmBox_Ay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Gelir);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGelirIstatistik";
            this.Text = "Gelir İstatistik";
            this.Load += new System.EventHandler(this.FrmGelirIstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_aylik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Gelir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmBox_Ay;
        private System.Windows.Forms.Label lbl_saTutar;
        private System.Windows.Forms.Label lbl_secilenAy;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_aylik;
    }
}