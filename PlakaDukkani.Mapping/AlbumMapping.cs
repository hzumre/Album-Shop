using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlakDukkani.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani.Mapping
{
    public class AlbumMapping:BaseEntityMapping<Album>
    {
        public override void Configure(EntityTypeBuilder<Album> album)
        {
            album.HasKey(x => x.ID);
            album.Property(x => x.Adi).HasMaxLength(200).HasAnnotation("Typname", "nvarchar").IsRequired();
            album.Property(x=>x.AlbumSanatcisi).HasMaxLength(200).HasAnnotation("Typname", "nvarchar").IsRequired();
            album.Property(x=>x.Fiyat).HasAnnotation("Typname", "money").IsRequired();
            album.Property(x=>x.CıkısTarihi).HasAnnotation("Typname", "datetime").IsRequired();
            album.Property(x=>x.Indirim).HasAnnotation("Typname", "money").IsRequired();
            album.Property(x=>x.SatisDevami).IsRequired();

            album.HasOne(x => x.Yonetici).WithMany(x => x.Albums).HasForeignKey(x => x.YoneticiID);

            base.Configure(album);
        }

    }
}
