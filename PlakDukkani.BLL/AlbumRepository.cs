using PlakDukkani.Core.Interface;
using PlakDukkani.DAL;
using PlakDukkani.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani.BLL
{
    public class AlbumRepository : IRepository<Album>
    {
        PlakDukkaniContext db = new();

        public void Add(Album item)
        {
            db.Albums.Add(item);
            db.SaveChanges();

        }

        public List<Album> GetAll()
        {
            return db.Albums.ToList();
        }

        public Album GetByID(int ID)
        {
            return db.Albums.Find(ID);
        }

        public void Remove(Album item)
        {
            db.Albums.Remove(item);
            db.SaveChanges();
        }

        public void Update(Album item)
        {
            db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
