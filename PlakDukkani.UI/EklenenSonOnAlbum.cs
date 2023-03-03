using PlakDukkani.DAL;
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
    public partial class EklenenSonOnAlbum : Form
    {
        public EklenenSonOnAlbum()
        {
            InitializeComponent();
        }

        PlakDukkaniContext db = new();
        private void EklenenSonOnAlbum_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Albums.Where(x => x.CıkısTarihi.Date.Day>(DateTime.Now.Day-10)).Select(x => new { x.Adi, x.AlbumSanatcisi }).ToList();
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
