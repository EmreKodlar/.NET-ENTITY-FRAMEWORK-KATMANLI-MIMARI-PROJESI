using EntityLayers.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IDoktorServices
    {
        void DoktorEkle(TBLDOKTOR p);
        void DoktorSil(TBLDOKTOR p);
        void DoktorGuncelle(TBLDOKTOR p);
        List<TBLDOKTOR> DoktorListele();
        TBLDOKTOR doktorIDgetir(int id);
        List<TBLDOKTOR> SartliDoktorListele(bool deger);
        void DoktorPasiflestirmeServisi(int id);

    }
}
