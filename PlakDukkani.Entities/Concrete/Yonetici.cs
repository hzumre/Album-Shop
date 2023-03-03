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
    public class Yonetici:BaseEntity,IEntity<int>
    {
        public int ID { get; set; }
        public string AdiSoyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public virtual List<Album> Albums { get; set; }


    }
}
