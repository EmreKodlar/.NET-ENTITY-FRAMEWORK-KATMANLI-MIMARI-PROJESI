using EntityLayers.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOdemeServices
    {
        void odemeEkle(TBLODEME odeme);
        void odemeSil(TBLODEME odeme);
        void odemeGuncelle(TBLODEME odeme);
        List<TBLODEME> odemeListele();
        TBLODEME odemeIDgetir(int id);

        List<TBLODEME> SartliOdemeListele(int id);

    
    }
}
