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
                hemsireler.Add(yeniHemsire);
                
                
                
                lstKisiler.Items.AddRange(hemsireler.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HemsireEkrani_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Branslar));
        }

    }
}
