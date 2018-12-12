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
        List<Doktor> doktorlar = new List<Doktor>();
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            Kisi doktor = new Doktor();
            try
            {
                doktor.Ad = txtAd.Text;
                doktor.Soyad = txtSoyad.Text;
                doktor.TCKN = txtTckn.Text;
                doktor.Email = txtEmail.Text;
                
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
