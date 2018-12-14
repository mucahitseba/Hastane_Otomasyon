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

        private void RandevuEkrani_Load(object sender, EventArgs e)
        {
            cmbServis.DataSource = Enum.GetValues(typeof(Branslar));
            lstHastalar.Items.AddRange(HastaEkrani.hastalar.ToArray());
        }

        private void lstHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seciliHasta = (Hasta)lstHastalar.SelectedItem;
            cmbServis.Enabled = true;
        }

        private void cmbServis_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilenServis = (Branslar)Enum.Parse(typeof(Branslar), cmbServis.SelectedItem.ToString());
            cmbDoktorlar.Enabled = true;
        }
		List<Button> seanslar = new List<Button>();
		
		protected void Tikla(object sender, EventArgs e)
		{
			Button button = sender as Button;
			MessageBox.Show(button.Text);
		}

        private void RandevuEkrani_Load_1(object sender, EventArgs e)
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
                    this.panel3.Controls.Add(btn);

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
    }
}
