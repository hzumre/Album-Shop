using PlakDukkani.BLL;
using PlakDukkani.Core.Enums;
using PlakDukkani.Entities.Concrete;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PlakDukkani.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        YoneticiRepository yoneticiRepository = new();
        private void btnKayýtOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                yoneticiRepository.Add(KullaniciOlustur());
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private string sha256_hash(string sifre) {
            using (SHA256 hash = SHA256Managed.Create()) 
            { 
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }
        public Yonetici KullaniciOlustur()
        {
            Yonetici yeniYonetici = new();

            if (txtAd.Text == null)
            {
                throw new Exception("Lütfen adýnýzý giriniz!");
            }
           
                yeniYonetici.AdiSoyadi = txtAd.Text;
          



            foreach (Yonetici item in yoneticiRepository.GetAll())
            {
                if (item.KullaniciAdi == txtKullaniciAdi.Text)
                {
                    throw new Exception("Bu Kullanýcý adý kullanýlmýþtýr.Lütfen baþka bir kullanýcý adý deneyiniz");
                }             
                                 
            }

            yeniYonetici.KullaniciAdi = txtKullaniciAdi.Text;

            int buyukharfMi = 0;
            int kucukharfMi = 0;
            char[] karakter = new char[4] { '!', ':', '+', '*' };
            int karakterSayýsý = 0;

            for (int i = 0; i < txtSifre.Text.Length; i++)
            {
                if (char.IsUpper(txtSifre.Text[i]))
                {
                    buyukharfMi++;
                }
                else if (char.IsLower(txtSifre.Text[i]))
                {

                    kucukharfMi++;
                }
                for (int j = 0; j < karakter.Length; j++)
                {
                    if (txtSifre.Text[i] == karakter[j])
                    {
                        karakterSayýsý++;
                    }
                }

            }


            if (txtSifre.Text.Length >= 8 && buyukharfMi >= 2 && kucukharfMi >= 3 && karakterSayýsý >= 2 && txtSifre.Text==txtSifreTekrar.Text)
            {
                
                yeniYonetici.Sifre = sha256_hash( txtSifre.Text);
            }
            else
            {
                throw new Exception("Lütfen þifrenizin uzunluðu sekiz karakterden büyük,içinde küçük ve büyük harf, (!,:,+ ve * )karakterlerinden en az iki tanesini içersin.");
            }


            if (rdbErkek == null && rdbKadin == null)
            {
                throw new Exception("Lütfen cinsiyetinizi giriniz!");
            }
            else
            {
                yeniYonetici.Cinsiyet = rdbErkek.Checked ? Cinsiyet.Erkek : Cinsiyet.Kadýn;
            }


            return yeniYonetici;
        }
    }
}