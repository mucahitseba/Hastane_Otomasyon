namespace HastaneOtomasyon
{
    partial class AcilisEkrani
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
            this.hastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşireToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaToolStripMenuItem,
            this.doktorToolStripMenuItem2,
            this.hemşireToolStripMenuItem1,
            this.personelToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastaToolStripMenuItem
            // 
            this.hastaToolStripMenuItem.Name = "hastaToolStripMenuItem";
            this.hastaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.hastaToolStripMenuItem.Text = "Hasta";
            this.hastaToolStripMenuItem.Click += new System.EventHandler(this.hastaToolStripMenuItem_Click);
            // 
            // doktorToolStripMenuItem2
            // 
            this.doktorToolStripMenuItem2.Name = "doktorToolStripMenuItem2";
            this.doktorToolStripMenuItem2.Size = new System.Drawing.Size(55, 20);
            this.doktorToolStripMenuItem2.Text = "Doktor";
            // 
            // hemşireToolStripMenuItem1
            // 
            this.hemşireToolStripMenuItem1.Name = "hemşireToolStripMenuItem1";
            this.hemşireToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.hemşireToolStripMenuItem1.Text = "Hemşire";
            // 
            // personelToolStripMenuItem1
            // 
            this.personelToolStripMenuItem1.Name = "personelToolStripMenuItem1";
            this.personelToolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
            this.personelToolStripMenuItem1.Text = "Personel";
            // 
            // AcilisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AcilisEkrani";
            this.Text = "Hastane Otomasyonu";
            this.Load += new System.EventHandler(this.AcilisEkrani_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem hemşireToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem1;
    }
}