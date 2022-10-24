using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayers.Concrete;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HastaManager : IHastaServices
    {
        IHastaDal _hastaDal; // Bu şekilde Interface'lerden değer alarak, bağımlılıkları azaltıyoruz.

        //Mantık şu, IHastaDal, IRepository'den türüyor. IRepository'nin içi ise
        //GenericREpository'de doluyor. 
        //Yani biz, IHastaDal'dan nesne türetip onu da bir constructur içinde değer ataması 
        //yaparsak, istediğimiz değerlere (GenericREpository sayesinde) ulaşabiliyoruz.
        public HastaManager(IHastaDal hastaDal) // constructur method
        {
            _hastaDal = hastaDal;
        }

        public void HastaPasiflestirmeServisi(int id)
        {
                 var deger= hastaIDgetir(id);
             
                deger.HASTAPASIF = !deger.HASTAPASIF; // sonuç neyse tersini yap -true - false 

               _hastaDal.pasifAktif(deger);
            
        }

        public void HastaEklemeServisi(TBLHASTA p)
        {

            _hastaDal.Ekle(p);

        }
        public void HastaGuncellemeServisi(TBLHASTA p)
        {
            _hastaDal.Guncelle(p);
        }
        public TBLHASTA hastaIDgetir(int id)
        {
            return _hastaDal.IDGetir(x=>x.HASTAID == id);
        }
        public List<TBLHASTA> HastaListe()
        {
            return _hastaDal.listele(); // ÖNEMLİ: listele() methodu genericRepository'den geliyor.
        }

        public List<TBLHASTA> HastaAktifListeServisi(bool deger)
        {
             
           return _hastaDal.Sartlilistele(x => x.HASTAPASIF == deger);
             
        }
    }
}
