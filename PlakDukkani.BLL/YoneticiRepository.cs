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
    public class YoneticiRepository : IRepository<Yonetici>
    {
        PlakDukkaniContext db = new();
        public void Add(Yonetici item)
        {

            db.Yoneticis.Add(item);
            db.SaveChanges();

        }

        public List<Yonetici> GetAll()
        {
            return db.Yoneticis.ToList();
        }

        public Yonetici GetByID(int ID)
        {
            return db.Yoneticis.Find(ID);
        }

        public void Remove(Yonetici item)
        {
            db.Yoneticis.Remove(item);
            db.SaveChanges();
        }

        public void Update(Yonetici item)
        {
            db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
