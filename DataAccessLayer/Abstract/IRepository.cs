using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        T IDGetir(Expression<Func<T, bool>> flter); // ID Getirme
        List<T> listele(); //Tümünü Listele
        void Ekle(T p); //p paramaetre değerlerine göre ekle
        void Sil(T p); //p paramaetre değerlerine göre sil
        void Guncelle(T p); //p paramaetre değerlerine göre güncelle
        List<T> Sartlilistele(Expression<Func<T, bool>> filter); //Şarta (filter'e) göre Listele

        void pasifAktif(T p); //p paramaetre değerlerine göre pasif ya da aktif yap

    }
}
