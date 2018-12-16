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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace HastaneOtomasyon
{
    public partial class RandevuEkrani : Form
    {
        public RandevuEkrani()
        {
            InitializeComponent();
        }

        private Hasta _seciliHasta;
        private Branslar _secilenServis;
        private Doktor _seciliDoktor;
        int dakika, saat, i;
        int sayac = 0;
        public DateTime randevuSaati;
        List<Button> seanslar = new List<Button>();
        List<Randevu> randevular = new List<Randevu>();

        private void RandevuEkrani_Load(object sender, EventArgs e)
        {
            cmbServis.DataSource = Enum.GetValues(typeof(Branslar));
            //cmbDoktorlar.Items.AddRange(DoktorEkrani.doktorlar.ToArray());
            lstHastalar.Items.AddRange(HastaEkrani.hastalar.ToArray());
            cmbCikti.Items.AddRange(DoktorEkrani.doktorlar.ToArray());
            cmbServis.Enabled = false;
            cmbDoktorlar.Enabled = false;
            
            for (i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Button btn = new Button();
                    btn.Name = "btn_" + (i * j).ToString();
                    btn.Location = new Point(50 * j + 20, i * 40 + 40);
                    btn.Size = new Size(50, 40);
                    btn.Click += new EventHandler(SeansSec);
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
            _seciliHasta = (Hasta)lstHastalar.SelectedItem;
            cmbServis.Enabled = true;
            
            
        }
        private void SeansSec(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button == null)return;
            randevuSaati = DateTime.Parse(button.Text);
        }

        private void cmbServis_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktorlar.Items.Clear();
            _secilenServis = (Branslar)Enum.Parse(typeof(Branslar), cmbServis.SelectedValue.ToString());
            foreach (Doktor doktor in DoktorEkrani.doktorlar)
            {
                if(_secilenServis == doktor.Brans)
                    cmbDoktorlar.Items.Add(doktor);
            }
            cmbDoktorlar.Enabled = true;   
        }

        private void cmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            _seciliDoktor = (Doktor)cmbDoktorlar.SelectedItem;
            foreach (Button btn in seanslar)
            {
                btn.Enabled = true;
            }
            btnRandevu.Enabled = true;
        }

        private void cmbCikti_SelectedIndexChanged(object sender, EventArgs e)
        {
            _seciliDoktor = (Doktor)cmbCikti.SelectedItem;
        }

        private void btnCiktiAl_Click(object sender, EventArgs e)
        {
            List<Randevu> seciliDoktorRandevular = new List<Randevu>(); Document raporum = new Document();
            PdfWriter.GetInstance(raporum, new FileStream("C:/Users/Oguz/Desktop/Raporum.pdf", FileMode.Create));
            raporum.AddCreationDate();
            if (raporum.IsOpen() == false)
                raporum.Open();

            foreach (Randevu randevu in randevular)
            {
                if (randevu.RandevuAlinanDoktor == _seciliDoktor)
                {
                    seciliDoktorRandevular.Add(randevu);
                    raporum.Add(new Paragraph($"{randevu.RandevuAlinanDoktor}{randevu.RandevuAlinanDoktor.Brans}"));
                    raporum.Add(new Paragraph($"{randevu.RandevuAlanHasta}{randevu.RandevuSaati}"));
                }
            }
            raporum.Close();
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            bool eslesmeVarmi = false;
            if (_seciliHasta.HastaRandevuList != null)
            {
                foreach (Randevu hastaRandevu in _seciliHasta.HastaRandevuList)
                {
                    if (hastaRandevu.RandevuSaati == randevuSaati && 
                        hastaRandevu.RandevuAlinanServis == _secilenServis)
                    {
                        MessageBox.Show("Seçtiğiniz seans ve serviste zaten bir randevunuz bulunmaktadır");
                        eslesmeVarmi = true;
                    }
                    else if (hastaRandevu.RandevuSaati == randevuSaati &&
                             hastaRandevu.RandevuAlinanServis != _secilenServis)
                    {
                        MessageBox.Show("Seçtiğiniz seansta başka serviste randevunuz bulunduğundan seçim yapamazsınız");
                        eslesmeVarmi = true;
                    }
                }

                //if (!eslesmeVarmi)
                //    RandevuOlustur();
            }

            if (_seciliDoktor.DoktorRandevuList != null)
            {
                foreach (Randevu doktorRandevu in _seciliDoktor.DoktorRandevuList)
                {
                    if (doktorRandevu.RandevuSaati == randevuSaati)
                    {
                        MessageBox.Show($"{doktorRandevu.RandevuAlinanDoktor.Ad} bey'in {doktorRandevu.RandevuSaati}" +
                                        $"seansında randevusu bulunduğundan bu seansı seçemezsiniz");
                        eslesmeVarmi = true;
                    }
                }
            }
            if (!eslesmeVarmi)
                RandevuOlustur();
        }

        private void RandevuOlustur()
        {
            Randevu randevu = new Randevu();
            randevu.RandevuAlanHasta = (Hasta)lstHastalar.SelectedItem;
            randevu.RandevuAlinanServis = (Branslar)Enum.Parse(typeof(Branslar), cmbServis.SelectedItem.ToString());
            randevu.RandevuAlinanDoktor = (Doktor)cmbDoktorlar.SelectedItem;
            randevu.RandevuSaati = randevuSaati;

            _seciliHasta.HastaRandevuList.Add(randevu);
            _seciliDoktor.DoktorRandevuList.Add(randevu);
            randevular.Add(randevu);
            ListViewItem randevuItem = lstWKayıt.Items.Add($"{randevu.RandevuAlanHasta}");
            randevuItem.SubItems.Add($"{randevu.RandevuAlinanServis}");
            randevuItem.SubItems.Add($"{randevu.RandevuAlinanDoktor}");
            randevuItem.SubItems.Add($"{randevu.RandevuSaati}");
        }
    }
}
