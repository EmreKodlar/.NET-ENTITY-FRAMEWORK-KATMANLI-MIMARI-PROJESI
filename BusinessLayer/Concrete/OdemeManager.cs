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
    public class OdemeManager : IOdemeServices
    {

        IOdemeDal _iodemeDal;

        public OdemeManager(IOdemeDal iodemeDal)
        {
            _iodemeDal = iodemeDal;
        }
 
        public void odemeEkle(TBLODEME odeme)
        {
            _iodemeDal.Ekle(odeme);
        }

        public void odemeGuncelle(TBLODEME odeme)
        {
            _iodemeDal.Guncelle(odeme);
        }

        public TBLODEME odemeIDgetir(int id)
        {
           return _iodemeDal.IDGetir(x=>x.ODEMEID==id);
        }

        public List<TBLODEME> odemeListele()
        {
            return _iodemeDal.listele();
        } 

        public void odemeSil(TBLODEME odeme)
        {
             _iodemeDal.Sil(odeme);
        }

        public List<TBLODEME> SartliOdemeListele(int id)
        {
            return _iodemeDal.Sartlilistele(x => x.ODEMEID == id);
        }  
    }
}
