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
            this.randevuEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaToolStripMenuItem,
            this.doktorToolStripMenuItem2,
            this.hemşireToolStripMenuItem1,
            this.personelToolStripMenuItem1,
            this.randevuEkranıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastaToolStripMenuItem
            // 
            this.hastaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaToolStripMenuItem.Image = global::HastaneOtomasyon.Properties.Resources.hasta;
            this.hastaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hastaToolStripMenuItem.Name = "hastaToolStripMenuItem";
            this.hastaToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.hastaToolStripMenuItem.Text = "Hasta";
            this.hastaToolStripMenuItem.Click += new System.EventHandler(this.hastaToolStripMenuItem_Click);
            // 
            // doktorToolStripMenuItem2
            // 
            this.doktorToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktorToolStripMenuItem2.Image = global::HastaneOtomasyon.Properties.Resources.doktor;
            this.doktorToolStripMenuItem2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doktorToolStripMenuItem2.Name = "doktorToolStripMenuItem2";
            this.doktorToolStripMenuItem2.Size = new System.Drawing.Size(89, 24);
            this.doktorToolStripMenuItem2.Text = "Doktor";
            this.doktorToolStripMenuItem2.Click += new System.EventHandler(this.doktorToolStripMenuItem2_Click);
            // 
            // hemşireToolStripMenuItem1
            // 
            this.hemşireToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hemşireToolStripMenuItem1.Image = global::HastaneOtomasyon.Properties.Resources.hemsire;
            this.hemşireToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hemşireToolStripMenuItem1.Name = "hemşireToolStripMenuItem1";
            this.hemşireToolStripMenuItem1.Size = new System.Drawing.Size(97, 24);
            this.hemşireToolStripMenuItem1.Text = "Hemşire";
            this.hemşireToolStripMenuItem1.Click += new System.EventHandler(this.hemşireToolStripMenuItem1_Click);
            // 
            // personelToolStripMenuItem1
            // 
            this.personelToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelToolStripMenuItem1.Image = global::HastaneOtomasyon.Properties.Resources.personel;
            this.personelToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personelToolStripMenuItem1.Name = "personelToolStripMenuItem1";
            this.personelToolStripMenuItem1.Size = new System.Drawing.Size(99, 24);
            this.personelToolStripMenuItem1.Text = "Personel";
            this.personelToolStripMenuItem1.Click += new System.EventHandler(this.personelToolStripMenuItem1_Click);
            // 
            // randevuEkranıToolStripMenuItem
            // 
            this.randevuEkranıToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.randevuEkranıToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevuEkranıToolStripMenuItem.Image = global::HastaneOtomasyon.Properties.Resources.randevu;
            this.randevuEkranıToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.randevuEkranıToolStripMenuItem.Name = "randevuEkranıToolStripMenuItem";
            this.randevuEkranıToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.randevuEkranıToolStripMenuItem.Text = "Randevu Ekranı";
            this.randevuEkranıToolStripMenuItem.Click += new System.EventHandler(this.randevuEkranıToolStripMenuItem_Click);
            // 
            // AcilisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 753);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ToolStripMenuItem randevuEkranıToolStripMenuItem;
    }
}