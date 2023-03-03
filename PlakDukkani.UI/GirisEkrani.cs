using PlakDukkani.BLL;
using PlakDukkani.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDukkani.UI
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        YoneticiRepository yoneticiRepository = new();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 kayitEkrani = new();
            kayitEkrani.ShowDialog();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            bool validUser = false;

            foreach (Yonetici item in yoneticiRepository.GetAll())
            {
                if (txtKullaniciAdi.Text == item.KullaniciAdi && txtSifre.Text == item.Sifre)
                {

                    Islemler islemler = new(item);
                    islemler.ShowDialog();
                    validUser = true;
                    this.Close();                  
                }
            }

            if (validUser == false)
            {
                MessageBox.Show("Kullanıcı Adınızı veya Şifrenizi Yanlış Girdiniz.Lütfen tekrar deneyiniz... ");
            }

        }
    }
}
