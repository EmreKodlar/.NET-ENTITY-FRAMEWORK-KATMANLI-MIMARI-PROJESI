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
    public class IslerController : Controller
    {

        IsManager im = new IsManager(new EFIsDal());

        HastaManager hm = new HastaManager(new EFHastaDal());

        DoktorManager dm = new DoktorManager(new EFDoktorDal());

        public ActionResult Index()
        {

            ViewBag.HastaSiralaEkle = new SelectList(hm.HastaListe(), "HASTAID", "HASTAAD"); // ekleme için gerekli

            ViewBag.DoktorSiralaEkle = new SelectList(dm.DoktorListele(), "DOKTORID", "DOKTORAD"); // ekleme için gerekli

            ViewBag.HastaSiralaDuzenle = hm.HastaListe(); // düzenlemek için gerekli

            ViewBag.DoktorSiralaDuzenle = dm.DoktorListele();// düzenlemek için gerekli

            ViewBag.isSirala = im.isListele();

            return View();
        }

        public ActionResult IsEkle(TBLISLER p)
        {
            im.isEkle(p);
            return RedirectToAction("Index");
        }

        public ActionResult IsSil(int id) // int id diye yazılmazsa hata veriyor...
        {
            var deger = im.isIDgetir(id);
            im.isSil(deger);
            return RedirectToAction("Index");
        }

        
        public ActionResult IsDuzenle(TBLISLER p) 
        {
            im.isGuncelle(p);
            return RedirectToAction("Index");
        }
    }
}