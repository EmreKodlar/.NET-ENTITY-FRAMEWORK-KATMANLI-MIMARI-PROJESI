using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayers.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DoktorManager : IDoktorServices
    {

        IDoktorDal _iDoktorDal;

        public DoktorManager(IDoktorDal DoktorDal)
        {
            _iDoktorDal = DoktorDal;
        }

        public void DoktorEkle(TBLDOKTOR p)
        {
            _iDoktorDal.Ekle(p);
        }

        public void DoktorGuncelle(TBLDOKTOR p)
        {
            _iDoktorDal.Guncelle(p);

        }

        public TBLDOKTOR doktorIDgetir(int id)
        {
           return _iDoktorDal.IDGetir(x => x.DOKTORID == id);
        }

        public List<TBLDOKTOR> DoktorListele()
        {
            return _iDoktorDal.listele();
        }

        public void DoktorPasiflestirmeServisi(int id)
        {
            var deger = doktorIDgetir(id);

            deger.DOKTORPASIF = !deger.DOKTORPASIF; // sonuç neyse tersini yap -true - false 

            _iDoktorDal.pasifAktif(deger);
        }

        public void DoktorSil(TBLDOKTOR p)
        {
            _iDoktorDal.Sil(p);
        }

        public List<TBLDOKTOR> SartliDoktorListele(bool deger)
        {
           return _iDoktorDal.Sartlilistele(x => x.DOKTORPASIF == deger);
        }
    }
}
