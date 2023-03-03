using PlakDukkani.Core.Enums;
using PlakDukkani.Core.Interface;
using PlakDukkani.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani.Entities.Concrete
{
    public class Album:BaseEntity,IEntity<int>
    {
        public int ID { get; set; }
        public int YoneticiID { get; set; }
        public string Adi { get; set; }
        public string AlbumSanatcisi { get; set; }
        public DateTime CıkısTarihi { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Indirim { get; set; }
        public SatisDevami SatisDevami { get; set; }

        public Yonetici Yonetici { get; set; }
    }
}
