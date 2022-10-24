using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context(); // Veritabanına bağlanma gibi düşün
        DbSet<T> _object; // veri tabanından gelen sınıf
        public GenericRepository()
        {
            _object=c.Set<T>(); // hangi sınıf olduğu constroctur ile biliniyor.
        }
        public void Ekle(T p)
        {
            //_object.Add(p);
            var addEntity = c.Entry(p);
            addEntity.State = EntityState.Added;
            c.SaveChanges();
        }
        public void Guncelle(T p)
        {
            var updateEntity = c.Entry(p);
            updateEntity.State = EntityState.Modified;
            c.SaveChanges();
        }
 
        public T IDGetir(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }
        public List<T> listele()
        {
            return _object.ToList();
        }
        public List<T> Sartlilistele(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void pasifAktif(T p)
        {
            var updateDurum = c.Entry(p);
            updateDurum.State = EntityState.Modified;
            c.SaveChanges();
        }
  

        public void Sil(T p)
        {     
            _object.Remove(p); c.SaveChanges();
        }
    }
}
