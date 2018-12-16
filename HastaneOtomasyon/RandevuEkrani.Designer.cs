namespace HastaneOtomasyon
{
    partial class RandevuEkrani
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
            this.lstHastalar = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbDoktorlar = new System.Windows.Forms.ComboBox();
            this.cmbServis = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRandevu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstWKayıt = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCikti = new System.Windows.Forms.ComboBox();
            this.btnCiktiAl = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstHastalar
            // 
            this.lstHastalar.FormattingEnabled = true;
            this.lstHastalar.Location = new System.Drawing.Point(122, 9);
            this.lstHastalar.Name = "lstHastalar";
            this.lstHastalar.Size = new System.Drawing.Size(153, 212);
            this.lstHastalar.TabIndex = 1;
            this.lstHastalar.SelectedIndexChanged += new System.EventHandler(this.lstHastalar_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.cmbDoktorlar);
            this.panel1.Controls.Add(this.cmbServis);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(349, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 60);
            this.panel1.TabIndex = 2;
            // 
            // cmbDoktorlar
            // 
            this.cmbDoktorlar.FormattingEnabled = true;
            this.cmbDoktorlar.Location = new System.Drawing.Point(119, 31);
            this.cmbDoktorlar.Name = "cmbDoktorlar";
            this.cmbDoktorlar.Size = new System.Drawing.Size(121, 21);
            this.cmbDoktorlar.TabIndex = 3;
            this.cmbDoktorlar.SelectedIndexChanged += new System.EventHandler(this.cmbDoktorlar_SelectedIndexChanged);
            // 
            // cmbServis
            // 
            this.cmbServis.FormattingEnabled = true;
            this.cmbServis.Location = new System.Drawing.Point(119, 5);
            this.cmbServis.Name = "cmbServis";
            this.cmbServis.Size = new System.Drawing.Size(121, 21);
            this.cmbServis.TabIndex = 2;
            this.cmbServis.SelectedIndexChanged += new System.EventHandler(this.cmbServis_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doktorlar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servis";
            // 
            // btnRandevu
            // 
            this.btnRandevu.Enabled = false;
            this.btnRandevu.Location = new System.Drawing.Point(122, 265);
            this.btnRandevu.Margin = new System.Windows.Forms.Padding(2);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Size = new System.Drawing.Size(153, 32);
            this.btnRandevu.TabIndex = 3;
            this.btnRandevu.Text = "Randevu Al";
            this.btnRandevu.UseVisualStyleBackColor = true;
            this.btnRandevu.Click += new System.EventHandler(this.btnRandevu_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(349, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 268);
            this.panel3.TabIndex = 4;
            // 
            // lstWKayıt
            // 
            this.lstWKayıt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.lstWKayıt.Location = new System.Drawing.Point(122, 358);
            this.lstWKayıt.Name = "lstWKayıt";
            this.lstWKayıt.Size = new System.Drawing.Size(500, 117);
            this.lstWKayıt.TabIndex = 5;
            this.lstWKayıt.UseCompatibleStateImageBehavior = false;
            this.lstWKayıt.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Hasta Adı Soyadı";
            this.columnHeader1.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Servis";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Doktor";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Saat";
            this.columnHeader5.Width = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Randevularının çıktısı alınacak olan doktoru seçiniz :";
            // 
            // cmbCikti
            // 
            this.cmbCikti.FormattingEnabled = true;
            this.cmbCikti.Location = new System.Drawing.Point(378, 490);
            this.cmbCikti.Name = "cmbCikti";
            this.cmbCikti.Size = new System.Drawing.Size(121, 21);
            this.cmbCikti.TabIndex = 7;
            this.cmbCikti.SelectedIndexChanged += new System.EventHandler(this.cmbCikti_SelectedIndexChanged);
            // 
            // btnCiktiAl
            // 
            this.btnCiktiAl.Location = new System.Drawing.Point(515, 488);
            this.btnCiktiAl.Name = "btnCiktiAl";
            this.btnCiktiAl.Size = new System.Drawing.Size(108, 23);
            this.btnCiktiAl.TabIndex = 8;
            this.btnCiktiAl.Text = "Çıktı Al";
            this.btnCiktiAl.UseVisualStyleBackColor = true;
            this.btnCiktiAl.Click += new System.EventHandler(this.btnCiktiAl_Click);
            // 
            // RandevuEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.btnCiktiAl);
            this.Controls.Add(this.cmbCikti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstWKayıt);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnRandevu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstHastalar);
            this.Name = "RandevuEkrani";
            this.Text = "Randevu Ekranı";
            this.Load += new System.EventHandler(this.RandevuEkrani_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstHastalar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRandevu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        
		
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbServis;
        private System.Windows.Forms.ComboBox cmbDoktorlar;
        private System.Windows.Forms.ListView lstWKayıt;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCikti;
        private System.Windows.Forms.Button btnCiktiAl;
    }
}

