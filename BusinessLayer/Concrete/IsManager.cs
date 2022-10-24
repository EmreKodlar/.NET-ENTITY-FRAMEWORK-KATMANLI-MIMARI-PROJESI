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
    public class IsManager : IIsServices
    {

        IIsDal _iisDal;

        public IsManager(IIsDal iisDal)
        {
            _iisDal = iisDal;
        }

        public void isEkle(TBLISLER odeme)
        {
            _iisDal.Ekle(odeme);
        }

        public void isGuncelle(TBLISLER odeme)
        {
            _iisDal.Guncelle(odeme);
        }

        public TBLISLER isIDgetir(int id)
        {
            return _iisDal.IDGetir(x => x.ISID == id);
        }

        public List<TBLISLER> isListele()
        {
            return _iisDal.listele();
        }

        public void isSil(TBLISLER odeme)
        {
            _iisDal.Sil(odeme);
        }
    }
}
