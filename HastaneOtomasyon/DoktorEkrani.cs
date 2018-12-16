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
    public partial class DoktorEkrani : Form
    {
        public DoktorEkrani()
        {
            InitializeComponent();
        }

        Calısan _doktor = new Doktor();

        public static List<Doktor> doktorlar = new List<Doktor>();
        //Hemsire seciliHemsire;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Calısan doktor = new Doktor();
            try
            {
                doktor.Ad = txtAd.Text;
                doktor.Soyad = txtSoyad.Text;
                doktor.Email = txtEmail.Text;
                doktor.Telefon = txtTelefon.Text;
                doktor.TCKN = txtTckn.Text;
                doktor.Brans= (Branslar)Enum.Parse(typeof(Branslar), cbBrans.SelectedItem.ToString());
                _doktor = doktor;
                doktorlar.Add((Doktor)doktor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FormuTemizle();
            lstDoktorlar.Items.AddRange(doktorlar.ToArray());
        }
        private void DoktorEkrani_Load(object sender, EventArgs e)
        {
            cbBrans.Items.AddRange(Enum.GetNames(typeof(Branslar)));
            //cbHemsire.Items.AddRange(HemsireEkrani.hemsireler.ToArray());
        }
        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDoktorlar.SelectedItem == null) return;

            Doktor seciliKisi = (Doktor)lstDoktorlar.SelectedItem;
            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            txtEmail.Text = seciliKisi.Email;
            txtTelefon.Text = seciliKisi.Telefon;
            txtTckn.Text = seciliKisi.TCKN;
            cbBrans.Text = seciliKisi.Brans.ToString();
            if (seciliKisi.Hemsire != null)
            {
                cbHemsire.Text = seciliKisi.Hemsire.ToString();
            }
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstDoktorlar.SelectedItem == null) return;

            Doktor seciliKisi = (Doktor)lstDoktorlar.SelectedItem;

            try
            {
                seciliKisi.Ad = txtAd.Text;
                seciliKisi.Soyad = txtSoyad.Text;
                seciliKisi.TCKN = txtTckn.Text;
                seciliKisi.Telefon = txtTelefon.Text;
                seciliKisi.Email = txtEmail.Text;
                seciliKisi.Brans = (Branslar)Enum.Parse(typeof(Branslar), cbBrans.SelectedItem.ToString());
                seciliKisi.Hemsire = (Hemsire)cbHemsire.SelectedItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (Hemsire hemsire in HemsireEkrani.hemsireler)
            {
                if ((Branslar)Enum.Parse(typeof(Branslar), cbBrans.SelectedItem.ToString()) == hemsire.Brans)
                    cbHemsire.Items.Add(hemsire);
            }

            FormuTemizle();
            lstDoktorlar.Items.AddRange(doktorlar.ToArray());
        }
        private void cbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHemsire.Items.Clear();
            string seciliBrans = (string)cbBrans.SelectedItem;
            foreach (Hemsire hemsire in HemsireEkrani.hemsireler)
            {
                if (seciliBrans == hemsire.Brans.ToString())
                    cbHemsire.Items.Add(hemsire);
            }
        }
        private void cbHemsire_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seciliHemsire = (Hemsire)cbHemsire.SelectedItem;
            seciliHemsire._atandiMi = true;
            _doktor.Hemsire = seciliHemsire;
            MessageBox.Show($"Doktor {_doktor.Ad} atanan hemsiresi : {_doktor.Hemsire}");
        }
    }
}
