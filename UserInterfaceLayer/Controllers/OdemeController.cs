using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
 
using EntityLayers.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInterfaceLayer.Controllers
{
    public class OdemeController : Controller
    {
        OdemeManager om = new OdemeManager(new EFOdemeDal());

        HastaManager hm = new HastaManager(new EFHastaDal());

        DoktorManager dm = new DoktorManager(new EFDoktorDal());

        public ActionResult Index( )
        { 
            ViewBag.HastaSiralaEkle = new SelectList(hm.HastaListe(), "HASTAID", "HASTAAD"); // ekleme için gerekli

            ViewBag.DoktorSiralaEkle = new SelectList(dm.DoktorListele(), "DOKTORID", "DOKTORAD"); // ekleme için gerekli

            ViewBag.odemeSirala = om.odemeListele(); // tablo sıralaması için gerekli

            return View(); 
        }
  
        public ActionResult OdemeEkle(TBLODEME p)
        {
            om.odemeEkle(p);
            return RedirectToAction("Index");
        } 
        public ActionResult OdemeSil(int id)  
        {
            var deger = om.odemeIDgetir(id);
            om.odemeSil(deger);
            return RedirectToAction("Index");
        }
 
        [HttpPost]
        public ActionResult OdemeDuzenle(TBLODEME p)
        {
            om.odemeGuncelle(p);

            ViewBag.HastaSirala = new SelectList(hm.HastaListe(), "HASTAID", "HASTAAD", p.HASTAID);

            ViewBag.DoktorSirala = new SelectList(dm.DoktorListele(), "DOKTORID", "DOKTORAD", p.DOKTORID);

            return View();
        }
        [HttpGet]
        public ActionResult OdemeDuzenle(int id) // int id diye yazılmazsa hata veriyor...
        { 
            var deger = om.odemeIDgetir(id);

            ViewBag.HastaSirala= new SelectList(hm.HastaListe(), "HASTAID", "HASTAAD", deger.HASTAID);  

            ViewBag.DoktorSirala = new SelectList(dm.DoktorListele(), "DOKTORID", "DOKTORAD", deger.DOKTORID);  

            return View(deger);
        }





    }
}