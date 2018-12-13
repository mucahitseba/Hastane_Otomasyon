using Classlar.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class RandevuEkrani : Form
    {
        public RandevuEkrani()
        {
            InitializeComponent();
        }
        
        private DoktorEkrani doktorEkrani;

        private void hemşireToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doktorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (doktorEkrani == null || doktorEkrani.IsDisposed)
            {
                doktorEkrani = new DoktorEkrani();
                doktorEkrani.MdiParent = this;
                doktorEkrani.Show();
            }

        }
		List<Button> seanslar = new List<Button>();
		private void RandevuEkrani_Load(object sender, EventArgs e)
        {
            cmbServis.DataSource = Enum.GetValues(typeof(Branslar));


			int dakika, saat, i;
			int sayac = 0;
			for (i = 0; i < 5; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					Button btn = new Button();
					btn.Name = "btn_" + (i * j).ToString();
					btn.Location = new System.Drawing.Point(50 * j + 20, i * 40 + 40);
					btn.Size = new System.Drawing.Size(50, 40);
					btn.Click += new EventHandler(Tikla);
					seanslar.Add(btn);
					this.panel2.Controls.Add(btn);

				}
			}

			for (saat = 9; saat <= 16; saat++)
			{
				if (saat == 12)
				{

					continue;
				}
				for (dakika = 0; dakika <= 45; dakika += 15)
				{
					if (sayac != 20)
					{
						seanslar[sayac].Text = saat.ToString("00") + " : " + dakika.ToString("00");
						sayac++;
					}
				}
			}
			


		}
		protected void Tikla(object sender, EventArgs e)
		{
			Button button = sender as Button;
			MessageBox.Show(button.Text);
		}

	}
}
