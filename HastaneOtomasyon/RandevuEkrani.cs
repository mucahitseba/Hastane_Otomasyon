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

        private void cmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilenDoktor = (Doktor)Enum.Parse(typeof(Doktor), DoktorEkrani.doktorlar.ToString());
        }
    }
}
