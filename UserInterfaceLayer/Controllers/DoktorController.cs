using BusinessLayer.Concrete;
using BusinessLayer.Validation;
using DataAccessLayer.EntityFrameWork;
using EntityLayers.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInterfaceLayer.Controllers
{
    public class DoktorController : Controller
    {

        DoktorManager dm = new DoktorManager( new EFDoktorDal());

        [HttpGet]
        public ActionResult Index()
        {
            bool deger = true;

            var doktorSirala = dm.SartliDoktorListele(deger); //  BussinesLayer Katmanındaki doktorManager'daki doktorAktifListe fonksiyonu geldi

            return View(doktorSirala);
        }

        [HttpPost]
        public ActionResult Index(TBLDOKTOR P)
        {

            var DoktorSirala = dm.DoktorListele(); //  BussinesLayer Katmanındaki DoktorManager'daki DoktorListele fonksiyonu geldi

            return View(DoktorSirala);
        }
 

        [HttpPost]
        public ActionResult YeniDoktor(TBLDOKTOR p)
        {
            DoktorValidator hd = new DoktorValidator(); // Doğrulama kuralları
            ValidationResult results = hd.Validate(p); // Bunun gelmesi için using FluentValidation.Results; kullanmamız lazım

            if (results.IsValid)
            {
                dm.DoktorEkle(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult doktorDuzenlemeSayfasi(int id)
        {
            var doktorBilgileri = dm.doktorIDgetir(id); // doktorManager.cs den gelen doktorIDgetir fonksiyonu

            return View(doktorBilgileri);
        }

        [HttpPost]
        public ActionResult doktorDuzenlemeSayfasi(TBLDOKTOR p)
        {

            DoktorValidator dv = new DoktorValidator(); // Doğrulama kuralları
            ValidationResult results = dv.Validate(p); // Bunun gelmesi için using FluentValidation.Results; kullanmamız lazım


            if (results.IsValid)
            {
                dm.DoktorGuncelle(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }


        public ActionResult doktorPasifYap(int id)
        {

            dm.DoktorPasiflestirmeServisi(id);

            return RedirectToAction("Index");
        }



    }
}