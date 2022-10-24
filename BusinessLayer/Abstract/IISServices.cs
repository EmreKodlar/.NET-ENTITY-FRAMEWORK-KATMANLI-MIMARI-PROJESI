using EntityLayers.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IIsServices
    {
        void isEkle(TBLISLER odeme);
        void isSil(TBLISLER odeme);
        void isGuncelle(TBLISLER odeme);
        List<TBLISLER> isListele();
        TBLISLER isIDgetir(int id);
 

    
    }
}
