using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classlar.Lib;
using Newtonsoft.Json;

namespace HastaneOtomasyon
{
    public partial class PersonelEkrani : Form
    {
        public PersonelEkrani()
        {
            InitializeComponent();
        }
        List<Personel> personeller = new List<Personel>();
        List<Personel> aramalar = new List<Personel>();
        

        private void PersonelEkrani_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Gorevler));
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Personel yeniPersonel = new Personel();
            try
            {
                yeniPersonel.Ad = txtAd.Text;
                yeniPersonel.Soyad = txtSoyad.Text;
                yeniPersonel.Email = txtEmail.Text;
                yeniPersonel.Telefon = txtTelefon.Text;
                yeniPersonel.TCKN = txtTckn.Text;
                yeniPersonel.Gorev = (Gorevler)comboBox1.SelectedItem;
                foreach (Personel personeller in personeller)
                {
                    if (personeller.TCKN == txtTckn.Text)
                    {
                        throw new Exception("Bu TC numarasıyla kayıtlı personel var");
                    }


                }
                personeller.Add(yeniPersonel);

                MessageBox.Show($"Hosgeldin {yeniPersonel.Ad} {yeniPersonel.Soyad}{yeniPersonel.Gorev}");
                FormuTemizle();
                lstPersoneller.Items.AddRange(personeller.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstPersoneller.SelectedItem == null) return;

            Personel seciliKisi = (Personel)lstPersoneller.SelectedItem;
            personeller.Remove(seciliKisi);

            FormuTemizle();
            lstPersoneller.Items.AddRange(personeller.ToArray());
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
            if (lstPersoneller.SelectedItem == null) return;

            Personel seciliKisi = (Personel)lstPersoneller.SelectedItem;

            try
            {
                seciliKisi.Ad = txtAd.Text;
                seciliKisi.Soyad = txtSoyad.Text;
                seciliKisi.TCKN = txtTckn.Text;
                seciliKisi.Telefon = txtTelefon.Text;
                seciliKisi.Email = txtEmail.Text;
                seciliKisi.Gorev = (Gorevler)comboBox1.SelectedItem;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FormuTemizle();
            
            lstPersoneller.Items.AddRange(personeller.ToArray());
        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            string ara = txtAra.Text.ToLower();
            aramalar = new List<Personel>();



            personeller.Where(kisi => kisi.Ad.ToLower().Contains(ara) || kisi.Soyad.ToLower().Contains(ara) || kisi.TCKN.StartsWith(ara)).ToList().ForEach(kisi => aramalar.Add(kisi));
            FormuTemizle();
            lstPersoneller.Items.AddRange(aramalar.ToArray());
        }

        

        private void içeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir JSON dosyası seçiniz";
            dosyaAc.Filter = "(JSON Dosyası) | *.json";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.FileName = "Personeller.json";
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream dosya = File.OpenRead(dosyaAc.FileName);
                    StreamReader reader = new StreamReader(dosya);
                    string dosyaIcerigi = reader.ReadToEnd();
                    reader.Close();
                    dosya.Close();
                    personeller = JsonConvert.DeserializeObject<List<Personel>>(dosyaIcerigi);


                    MessageBox.Show($"{personeller.Count} kisi sisteme basariyla eklendi");
                    lstPersoneller.Items.Clear();
                    lstPersoneller.Items.AddRange(personeller.ToArray());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata olustu: " + ex.Message);
                }
            }
        }

        private void dışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaKaydet.Title = "Bir JSON dosyası seçiniz";
            dosyaKaydet.Filter = "(JSON Dosyası) | *.json";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaKaydet.FileName = "Personeller.json";
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                FileStream file = File.Open(dosyaKaydet.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(file);
                writer.Write(JsonConvert.SerializeObject(personeller));
                writer.Close();
                writer.Dispose();
            }
        }

        private void lstPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPersoneller.SelectedItem == null) return;


            Personel seciliKisi = (Personel)lstPersoneller.SelectedItem;
            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            txtEmail.Text = seciliKisi.Email;
            txtTelefon.Text = seciliKisi.Telefon;
            txtTckn.Text = seciliKisi.TCKN;
            comboBox1.Text = seciliKisi.Gorev.ToString();
        }
    }
}
