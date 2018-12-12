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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.çalışanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstHastalar = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanlarToolStripMenuItem,
            this.hastaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // çalışanlarToolStripMenuItem
            // 
            this.çalışanlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorToolStripMenuItem,
            this.hemşireToolStripMenuItem,
            this.personelToolStripMenuItem});
            this.çalışanlarToolStripMenuItem.Name = "çalışanlarToolStripMenuItem";
            this.çalışanlarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.çalışanlarToolStripMenuItem.Text = "Çalışanlar";
            // 
            // doktorToolStripMenuItem
            // 
            this.doktorToolStripMenuItem.Name = "doktorToolStripMenuItem";
            this.doktorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doktorToolStripMenuItem.Text = "Doktor";
            // 
            // hemşireToolStripMenuItem
            // 
            this.hemşireToolStripMenuItem.Name = "hemşireToolStripMenuItem";
            this.hemşireToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hemşireToolStripMenuItem.Text = "Hemşire";
            this.hemşireToolStripMenuItem.Click += new System.EventHandler(this.hemşireToolStripMenuItem_Click);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // hastaToolStripMenuItem
            // 
            this.hastaToolStripMenuItem.Name = "hastaToolStripMenuItem";
            this.hastaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.hastaToolStripMenuItem.Text = "Hasta";
            // 
            // lstHastalar
            // 
            this.lstHastalar.FormattingEnabled = true;
            this.lstHastalar.Location = new System.Drawing.Point(25, 60);
            this.lstHastalar.Name = "lstHastalar";
            this.lstHastalar.Size = new System.Drawing.Size(120, 134);
            this.lstHastalar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(257, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 234);
            this.panel1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(118, 40);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // RandevuEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 354);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstHastalar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RandevuEkrani";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çalışanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemşireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaToolStripMenuItem;
        private System.Windows.Forms.ListBox lstHastalar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

