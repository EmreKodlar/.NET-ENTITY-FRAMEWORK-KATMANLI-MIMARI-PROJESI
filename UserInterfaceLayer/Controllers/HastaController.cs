using BusinessLayer.Concrete;
using BusinessLayer.Validation;
using DataAccessLayer.EntityFrameWork;
using EntityLayers.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInterfaceLayer.Controllers
{
    public class HastaController : Controller
    {

        HastaManager hm = new HastaManager(new EFHastaDal()); // BussinesLayer Katmanı içine DAL katmanındaki EF klasörü

        //public class EFHastaDal : GenericRepository<TBLHASTA>, IHastaDal

       [HttpGet]
        public ActionResult HastaGetir() 
        {
            bool deger = true;

            var hastaSirala = hm.HastaAktifListeServisi(deger); //  BussinesLayer Katmanındaki HastaManager'daki HastaAktifListe fonksiyonu geldi

            return View(hastaSirala);
        }

        [HttpPost]
        public ActionResult HastaGetir(TBLHASTA P)
        {

            var hastaSirala = hm.HastaListe(); //  BussinesLayer Katmanındaki HastaManager'daki HastaListe fonksiyonu geldi

            return View(hastaSirala);
        }

        public ActionResult HastaGetirPasif()
        {
            bool deger = false;

            var hastaSirala = hm.HastaAktifListeServisi(deger); //  BussinesLayer Katmanındaki HastaManager'daki HastaAktifListe fonksiyonu geldi

            return RedirectToAction("HastaGetir", hastaSirala);
        }

        [HttpPost]
        public ActionResult YeniHasta(TBLHASTA p)
        {
            HastaValidator hd = new HastaValidator(); // Doğrulama kuralları
            ValidationResult results = hd.Validate(p); // Bunun gelmesi için using FluentValidation.Results; kullanmamız lazım

            if (results.IsValid)
            {
                hm.HastaEklemeServisi(p);
                return RedirectToAction("HastaGetir");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return RedirectToAction("HastaGetir");
        }

        [HttpGet]
        public ActionResult hastaDuzenlemeSayfasi(int id)
        {
            var hastaBilgileri = hm.hastaIDgetir(id); // HastaManager.cs den gelen hastaIDgetir fonksiyonu

            return View(hastaBilgileri);
        }

        [HttpPost]
        public ActionResult hastaDuzenlemeSayfasi(TBLHASTA p)
        {

            HastaValidator hd = new HastaValidator(); // Doğrulama kuralları
            ValidationResult results = hd.Validate(p); // Bunun gelmesi için using FluentValidation.Results; kullanmamız lazım

            if (results.IsValid)
            {
                hm.HastaGuncellemeServisi(p);
                return RedirectToAction("HastaGetir");
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
         

        public ActionResult hastaPasifYap(int id)
        {
           
            hm.HastaPasiflestirmeServisi(id);
 
            return RedirectToAction("HastaGetir");
        }

    }
}