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
			this.button21 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.cmbServis = new System.Windows.Forms.ComboBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstHastalar
			// 
			this.lstHastalar.FormattingEnabled = true;
			this.lstHastalar.Location = new System.Drawing.Point(25, 60);
			this.lstHastalar.Name = "lstHastalar";
			this.lstHastalar.Size = new System.Drawing.Size(153, 199);
			this.lstHastalar.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Controls.Add(this.cmbServis);
			this.panel1.Location = new System.Drawing.Point(264, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(272, 82);
			this.panel1.TabIndex = 2;
			// 
			// button21
			// 
			this.button21.Location = new System.Drawing.Point(63, 297);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(75, 23);
			this.button21.TabIndex = 3;
			this.button21.Text = "Randevu Al";
			this.button21.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Doktorlar";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(56, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Servis";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(118, 40);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 0;
			// 
			// cmbServis
			// 
			this.cmbServis.FormattingEnabled = true;
			this.cmbServis.Location = new System.Drawing.Point(118, 13);
			this.cmbServis.Name = "cmbServis";
			this.cmbServis.Size = new System.Drawing.Size(121, 21);
			this.cmbServis.TabIndex = 0;
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(25, 382);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(511, 108);
			this.listView1.TabIndex = 3;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(264, 112);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(272, 241);
			this.panel2.TabIndex = 4;
			// 
			// RandevuEkrani
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(617, 537);
			this.Controls.Add(this.button21);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lstHastalar);
			this.Name = "RandevuEkrani";
			this.Text = "Randevu Ekranı";
			this.Load += new System.EventHandler(this.RandevuEkrani_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstHastalar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cmbServis;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Panel panel2;
	}
}

