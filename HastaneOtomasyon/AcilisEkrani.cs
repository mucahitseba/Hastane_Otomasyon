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
    public partial class AcilisEkrani : Form
    {
        public AcilisEkrani()
        {
            InitializeComponent();
        }
        private RandevuEkrani randevuEkrani;

        private void AcilisEkrani_Load(object sender, EventArgs e)
        {
            if (randevuEkrani == null || randevuEkrani.IsDisposed)
            {
                randevuEkrani = new RandevuEkrani();
                randevuEkrani.MdiParent = this;
                randevuEkrani.Dock = DockStyle.Fill;
                randevuEkrani.Show();   
            }
        }

        private void hastaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
