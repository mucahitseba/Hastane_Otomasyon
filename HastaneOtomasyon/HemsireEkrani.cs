using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classlar.Lib;

namespace HastaneOtomasyon
{
    public partial class HemsireEkrani : Form
    {
        public HemsireEkrani()
        {
            InitializeComponent();
        }
        List<Hemsire> hemsireler = new List<Hemsire>();
        List<Hemsire> aramalar = new List<Hemsire>();
        
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Hemsire yeniHemsire = new Hemsire();
            try
            {
                yeniHemsire.Ad = txtAd.Text;
                yeniHemsire.Soyad = txtSoyad.Text;
                yeniHemsire.Email = txtEmail.Text;
                yeniHemsire.Telefon = txtTelefon.Text;
                yeniHemsire.TCKN = txtTckn.Text;
                yeniHemsire.brans = (Branslar)comboBox1.SelectedItem;
                hemsireler.Add(yeniHemsire);
                
                MessageBox.Show($"Hosgeldin {yeniHemsire.Ad} {yeniHemsire.Soyad}{yeniHemsire.brans}");
                FormuTemizle();
                lstKisiler.Items.AddRange(hemsireler.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            Hemsire seciliKisi = (Hemsire)lstKisiler.SelectedItem;

            try
            {
                seciliKisi.Ad = txtAd.Text;
                seciliKisi.Soyad = txtSoyad.Text;
                seciliKisi.TCKN = txtTckn.Text;
                seciliKisi.Telefon = txtTelefon.Text;
                seciliKisi.Email = txtEmail.Text;
                seciliKisi.brans = (Branslar)comboBox1.SelectedItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FormuTemizle();
            lstKisiler.Items.AddRange(hemsireler.ToArray());
        }
        private void FormuTemizle()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Name == "txtAra")
                        continue;
                    control.Text = string.Empty;
                }
                else if (control is CheckBox)
                    (control as CheckBox).Checked = false;
                else if (control is ListBox lstBox)
                    lstBox.Items.Clear();
                else if (control is ComboBox cmbox)
                    cmbox.Text = "";

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            Hemsire seciliKisi = (Hemsire)lstKisiler.SelectedItem;
            hemsireler.Remove(seciliKisi);

            FormuTemizle();
            lstKisiler.Items.AddRange(hemsireler.ToArray());
        }
        private void txtAra_KeyUp(object sender, EventArgs e)
        {
            string ara = txtAra.Text.ToLower();
            aramalar = new List<Hemsire>();



            hemsireler.Where(kisi => kisi.Ad.ToLower().Contains(ara) || kisi.Soyad.ToLower().Contains(ara) || kisi.TCKN.StartsWith(ara)).ToList().ForEach(kisi => aramalar.Add(kisi));
            FormuTemizle();
            lstKisiler.Items.AddRange(aramalar.ToArray());
        }
        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;


            Hemsire seciliKisi = (Hemsire)lstKisiler.SelectedItem;
            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            txtEmail.Text = seciliKisi.Email;
            txtTelefon.Text = seciliKisi.Telefon;
            txtTckn.Text = seciliKisi.TCKN;
            comboBox1.Text = seciliKisi.brans.ToString();
        }

        private void HemsireEkrani_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Branslar));
        }
    }
}
