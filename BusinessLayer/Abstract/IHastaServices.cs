using EntityLayers.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHastaServices
    {

        List<TBLHASTA> HastaListe();

        void HastaEklemeServisi(TBLHASTA p);

        void HastaGuncellemeServisi(TBLHASTA p);

        TBLHASTA hastaIDgetir(int id);

        void HastaPasiflestirmeServisi(int id);

        List<TBLHASTA> HastaAktifListeServisi(bool deger);
    }
}
