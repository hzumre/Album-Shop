using PlakDukkani.BLL;
using PlakDukkani.Core.Enums;
using PlakDukkani.DAL;
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
    public partial class Islemler : Form
    {
        public Islemler()
        {
            InitializeComponent();
        }

        PlakDukkaniContext db = new();
        AlbumRepository albumRepository = new();

        Yonetici _yonetici = new();
        public Islemler(Yonetici item)
        {
            _yonetici = item;
            InitializeComponent();
        }
        void EkrandaGoster()
        {
            dataGridView1.DataSource = db.Albums.Select(x => new { x.Adi, x.AlbumSanatcisi }).ToList();
        }
        void TextiSil()
        {
            txtAdi.Clear();
            txtFiyat.Clear();
            txtIndirim.Clear();
            txtSanatci.Clear();
            rdEvet.Checked = false;
            rdHayir.Checked = false;
            dateTimePicker1.Value = DateTime.Today;
        }
        Album AlbumOlustur()
        {
            Album album = new Album();

            album.Adi = txtAdi.Text;
            album.YoneticiID = _yonetici.ID;
            album.AlbumSanatcisi = txtSanatci.Text;
            album.CıkısTarihi = dateTimePicker1.Value;
            album.Fiyat = Convert.ToDecimal(txtFiyat.Text);
            album.Indirim = Convert.ToDecimal(txtIndirim.Text);
            album.SatisDevami = rdEvet.Checked ? SatisDevami.Evet : SatisDevami.Hayır;
            return album;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            albumRepository.Add(AlbumOlustur());
            EkrandaGoster();
            TextiSil();
        }

        private void btnAlbumListesi_Click(object sender, EventArgs e)
        {
            AlbumListesi albumListesi = new();
            albumListesi.ShowDialog();
        }

        private void btnSatisiDevam_Click(object sender, EventArgs e)
        {
            SatisiDevamEdenAlbumler satisiDevamEdenAlbumler = new();
            satisiDevamEdenAlbumler.ShowDialog();
        }

        private void btnSatisiDurmus_Click(object sender, EventArgs e)
        {
            SatisiDurmusAlbümler satisiDurmusAlbümler = new();
            satisiDurmusAlbümler.ShowDialog();
        }

        private void btnIndirim_Click(object sender, EventArgs e)
        {
            IndirimdekiAlbumler indirimdekiAlbumler = new();
            indirimdekiAlbumler.ShowDialog();
        }

        private void btnSonOn_Click(object sender, EventArgs e)
        {
            EklenenSonOnAlbum eklenenSonOnAlbum = new();
            eklenenSonOnAlbum.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string albumAdi = selectedRow.Cells[0].Value.ToString();
                string sanatciAdi = selectedRow.Cells[1].Value.ToString();
                Album albumToDelete = db.Albums.Where(x => x.Adi == albumAdi && x.AlbumSanatcisi == sanatciAdi).FirstOrDefault();

                albumRepository.Remove(albumToDelete);
                EkrandaGoster();
            }

            else
            {
                MessageBox.Show("Lütfen Silinecek Satırı Seçiniz");

            }
        }

        private void Islemler_Load(object sender, EventArgs e)
        {
            EkrandaGoster();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string albumAdi = selectedRow.Cells[0].Value.ToString();
                string sanatciAdi = selectedRow.Cells[1].Value.ToString();
                Album selectAlbum = db.Albums.Where(x => x.Adi == albumAdi && x.AlbumSanatcisi == sanatciAdi).FirstOrDefault();

                selectAlbum.Adi = txtAdi.Text;
                selectAlbum.AlbumSanatcisi = txtSanatci.Text;
                selectAlbum.CıkısTarihi = dateTimePicker1.Value;
                selectAlbum.Fiyat = Convert.ToDecimal(txtFiyat.Text);
                selectAlbum.Indirim = Convert.ToDecimal(txtIndirim.Text);
                selectAlbum.SatisDevami = rdEvet.Checked ? SatisDevami.Evet : SatisDevami.Hayır;
                albumRepository.Update(selectAlbum);
                EkrandaGoster();
                TextiSil();
            }

            else
            {
                MessageBox.Show("Lütfen Guncellenecek Satırı Seçiniz");

            }
        }
    }
}
