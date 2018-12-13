﻿using Classlar.Lib;
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
    public partial class HastaEkrani : Form
    {
        public HastaEkrani()
        {
            InitializeComponent();
        }

        private void HastaEkrani_Load(object sender, EventArgs e)
        {

        }
        public static List<Kisi> hastalar = new List<Kisi>();
        List<Kisi> aramalar = new List<Kisi>();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kisi yeniHasta = new Hasta();
            try
            {
                yeniHasta.Ad = txtAd.Text;
                yeniHasta.Soyad = txtSoyad.Text;
                yeniHasta.Email = txtEmail.Text;
                yeniHasta.Telefon = txtTelefon.Text;
                yeniHasta.TCKN = txtTckn.Text;

                hastalar.Add(yeniHasta);
                
                FormuTemizle();
                lstHasta.Items.AddRange(hastalar.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstHasta.SelectedItem == null) return;

            Kisi seciliKisi = (Kisi)lstHasta.SelectedItem;

            try
            {
                seciliKisi.Ad = txtAd.Text;
                seciliKisi.Soyad = txtSoyad.Text;
                seciliKisi.TCKN = txtTckn.Text;
                seciliKisi.Telefon = txtTelefon.Text;
                seciliKisi.Email = txtEmail.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FormuTemizle();
            lstHasta.Items.AddRange(hastalar.ToArray());
        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            string ara = txtAra.Text.ToLower();
            aramalar = new List<Kisi>();

            

            
            hastalar.Where(kisi => kisi.Ad.ToLower().Contains(ara) || kisi.Soyad.ToLower().Contains(ara) || kisi.TCKN.StartsWith(ara)).ToList().ForEach(kisi => aramalar.Add(kisi));

            FormuTemizle();
            lstHasta.Items.AddRange(aramalar.ToArray());
        }

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHasta.SelectedItem == null) return;

           
            Kisi seciliKisi = (Kisi)lstHasta.SelectedItem;
            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            txtEmail.Text = seciliKisi.Email;
            txtTelefon.Text = seciliKisi.Telefon;
            txtTckn.Text = seciliKisi.TCKN;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstHasta.SelectedItem == null) return;

            Kisi seciliKisi = (Kisi)lstHasta.SelectedItem;
            hastalar.Remove(seciliKisi);

            FormuTemizle();
            lstHasta.Items.AddRange(hastalar.ToArray());
        }
    }
    }
    

