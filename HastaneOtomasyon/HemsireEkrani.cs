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
    public partial class HemsireEkrani : Form
    {
        public HemsireEkrani()
        {
            InitializeComponent();
        }
        public static List<Hemsire> hemsireler = new List<Hemsire>();
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
                yeniHemsire.Brans = (Branslar)comboBox1.SelectedItem;
                foreach (Hemsire hemsireler in hemsireler)
                {
                    if (hemsireler.TCKN == txtTckn.Text)
                    {
                        throw new Exception("Bu TC numarasıyla kayıtlı hemşire var");
                    }


                }
                hemsireler.Add(yeniHemsire);
                
                
                
                MessageBox.Show($"Hosgeldin {yeniHemsire.Ad} {yeniHemsire.Soyad}{yeniHemsire.Brans}");
                FormuTemizle();
                lstHemsire.Items.AddRange(hemsireler.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstHemsire.SelectedItem == null) return;

            Hemsire seciliKisi = (Hemsire)lstHemsire.SelectedItem;

            try
            {
                seciliKisi.Ad = txtAd.Text;
                seciliKisi.Soyad = txtSoyad.Text;
                seciliKisi.TCKN = txtTckn.Text;
                seciliKisi.Telefon = txtTelefon.Text;
                seciliKisi.Email = txtEmail.Text;
                seciliKisi.Brans = (Branslar)comboBox1.SelectedItem;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FormuTemizle();
            lstHemsire.Items.AddRange(hemsireler.ToArray());


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
            if (lstHemsire.SelectedItem == null) return;

            Hemsire seciliKisi = (Hemsire)lstHemsire.SelectedItem;
            hemsireler.Remove(seciliKisi);

            FormuTemizle();
            lstHemsire.Items.AddRange(hemsireler.ToArray());
        }
        private void txtAra_KeyUp(object sender, EventArgs e)
        {
            string ara = txtAra.Text.ToLower();
            aramalar = new List<Hemsire>();



            hemsireler.Where(kisi => kisi.Ad.ToLower().Contains(ara) || kisi.Soyad.ToLower().Contains(ara) || kisi.TCKN.StartsWith(ara)).ToList().ForEach(kisi => aramalar.Add(kisi));
            FormuTemizle();
            lstHemsire.Items.AddRange(aramalar.ToArray());
        }
        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHemsire.SelectedItem == null) return;


            Hemsire seciliKisi = (Hemsire)lstHemsire.SelectedItem;
            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            txtEmail.Text = seciliKisi.Email;
            txtTelefon.Text = seciliKisi.Telefon;
            txtTckn.Text = seciliKisi.TCKN;
            comboBox1.Text = seciliKisi.Brans.ToString();
        }

        private void HemsireEkrani_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Branslar));
        }

        private void içeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir JSON dosyası seçiniz";
            dosyaAc.Filter = "(JSON Dosyası) | *.json";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.FileName = "Hemsireler.json";
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream dosya = File.OpenRead(dosyaAc.FileName);
                    StreamReader reader = new StreamReader(dosya);
                    string dosyaIcerigi = reader.ReadToEnd();
                    reader.Close();
                    dosya.Close();
                    hemsireler = JsonConvert.DeserializeObject<List<Hemsire>>(dosyaIcerigi);


                    MessageBox.Show($"{hemsireler.Count} kisi sisteme basariyla eklendi");
                    lstHemsire.Items.Clear();
                    lstHemsire.Items.AddRange(hemsireler.ToArray());
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
            dosyaKaydet.FileName = "Hemsireler.json";
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                FileStream file = File.Open(dosyaKaydet.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(file);
                writer.Write(JsonConvert.SerializeObject(hemsireler));
                writer.Close();
                writer.Dispose();
            }
        }

        
    }
}
