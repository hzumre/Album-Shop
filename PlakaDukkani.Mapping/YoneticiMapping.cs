using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlakDukkani.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani.Mapping
{
    public class YoneticiMapping:BaseEntityMapping<Yonetici>
    {
        public override void Configure(EntityTypeBuilder<Yonetici> yonetici)
        {
            yonetici.HasKey(x => x.ID);
            yonetici.Property(x=>x.AdiSoyadi).HasMaxLength(200).HasAnnotation("Typname", "nvarchar").IsRequired();
            yonetici.Property(x=>x.KullaniciAdi).HasMaxLength(200).HasAnnotation("Typname", "nvarchar").IsRequired();
            yonetici.Property(x=>x.Sifre).HasMaxLength(200).HasAnnotation("Typname", "nvarchar").IsRequired();
            yonetici.Property(x => x.Cinsiyet).IsRequired();

            base.Configure(yonetici);
        }
    }
}
