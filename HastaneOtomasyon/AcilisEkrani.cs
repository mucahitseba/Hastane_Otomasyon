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
        private HastaEkrani hastaEkrani;
        private DoktorEkrani doktorEkrani;
        private PersonelEkrani personelEkrani;
        private HemsireEkrani hemsireEkrani;

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
            if (hastaEkrani == null || hastaEkrani.IsDisposed)
            {
                hastaEkrani = new HastaEkrani();
                hastaEkrani.MdiParent = this;
                hastaEkrani.Dock = DockStyle.Fill;
                randevuEkrani.Close();
                hastaEkrani.Show();
                
                
            }
        }

        private void randevuEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (randevuEkrani == null || randevuEkrani.IsDisposed)
            {
                randevuEkrani = new RandevuEkrani();
                randevuEkrani.MdiParent = this;
                randevuEkrani.Dock = DockStyle.Fill;
                randevuEkrani.Show();
            }
        }

        private void hemşireToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (hemsireEkrani == null || hemsireEkrani.IsDisposed)
            {
                hemsireEkrani = new HemsireEkrani();
                hemsireEkrani.MdiParent = this;
                hemsireEkrani.Dock = DockStyle.Fill;
                hemsireEkrani.Show();
            }
        }

        private void doktorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (doktorEkrani == null || doktorEkrani.IsDisposed)
            {
                doktorEkrani = new DoktorEkrani();
                doktorEkrani.MdiParent = this;
                doktorEkrani.Dock = DockStyle.Fill;
                doktorEkrani.Show();
            }
        }

        private void personelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (personelEkrani == null || personelEkrani.IsDisposed)
            {
                personelEkrani = new PersonelEkrani();
                personelEkrani.MdiParent = this;
                personelEkrani.Dock = DockStyle.Fill;
                personelEkrani.Show();
            }
        }
    }
}
