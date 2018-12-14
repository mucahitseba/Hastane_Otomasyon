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
            //cmbDoktorlar.Items.AddRange(DoktorEkrani.doktorlar.ToArray());
            lstHastalar.Items.AddRange(HastaEkrani.hastalar.ToArray());
            cmbServis.Enabled = false;
            cmbDoktorlar.Enabled = false;
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
                    btn.Enabled = false;

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

        private void lstHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seciliHasta = (Hasta)lstHastalar.SelectedItem;
            cmbServis.Enabled = true;
            
            
        }

        
		List<Button> seanslar = new List<Button>();
		
		protected void Tikla(object sender, EventArgs e)
		{
            Button button = sender as Button;
            
            
                
                string[] kayıt = { lstHastalar.Text, cmbServis.Text, cmbDoktorlar.Text, button.Text };
                var satir = new ListViewItem(kayıt);
                lstWKayıt.Items.Add(satir); 
            

        }

    

        private void cmbServis_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktorlar.Items.Clear();
            var secilenServis = (Branslar)Enum.Parse(typeof(Branslar), cmbServis.SelectedValue.ToString());
            foreach (Doktor doktor in DoktorEkrani.doktorlar)
            {
                if(secilenServis == doktor.Brans)
                    cmbDoktorlar.Items.Add(doktor);
            }
            cmbDoktorlar.Enabled = true;   
        }

        private void cmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Button btn in seanslar)
            {
                btn.Enabled = true;
            }
            button21.Enabled = true;
        }

        
    }
}
