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
    public partial class IndirimdekiAlbumler : Form
    {
        public IndirimdekiAlbumler()
        {
            InitializeComponent();
        }

        PlakDukkaniContext db = new();
        private void IndirimdekiAlbumler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Albums.Where(x => x.Indirim >0).OrderByDescending(x=>x.Indirim).Select(x => new { x.Adi, x.AlbumSanatcisi }).ToList();
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
