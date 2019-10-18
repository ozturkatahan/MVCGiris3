using MVCGiris3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVCGiris3.Controllers
{
    public class KisilerController : Controller
    {
        KisiContext db = new KisiContext();
        // GET: Kisiler
        public ActionResult Index(int? dogumYeriId, string ara, string sirala = "Id", string siralaYon = "Artan")
        {
            IQueryable<Kisi> sorgu = db.Kisiler;
            if (dogumYeriId.HasValue)
            {
                sorgu = sorgu.Where(x => x.DogumYeriId == dogumYeriId);
            }

            if (!string.IsNullOrEmpty(ara))
            {
                sorgu = sorgu.Where(x => x.Ad.Contains(ara) || x.Soyad.Contains(ara));
            }

            siralaYon = siralaYon.ToLower();
            switch (sirala.ToLower(CultureInfo.InvariantCulture))
            {
                case "id":
                    sorgu = siralaYon == "artan" ? sorgu.OrderBy(x => x.Id) : sorgu.OrderByDescending(x => x.Id);
                    break;

                case "ad":
                    sorgu = siralaYon == "artan" ? sorgu.OrderBy(x => x.Ad) : sorgu.OrderByDescending(x => x.Ad);
                    break;

                case "soyad":
                    sorgu = siralaYon == "artan" ? sorgu.OrderBy(x => x.Soyad) : sorgu.OrderByDescending(x => x.Soyad);
                    break;

                case "dogumyeri":
                    sorgu = siralaYon == "artan" ? sorgu.OrderBy(x => x.DogumYeri.SehirAd) : sorgu.OrderByDescending(x => x.DogumYeri.SehirAd);
                    break;
                default:
                    sorgu = siralaYon == "artan" ? sorgu.OrderBy(x => x.Id) : sorgu.OrderByDescending(x => x.Id);
                    break;
            }
            ViewBag.DogumYeriId = new SelectList(db.Sehirler.ToList(), "Id", "SehirAd");
            return View(sorgu.ToList());
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ekle(Kisi kisi)
        {
            //veriler geçerli ise (örneğin zorunlu alanlar girilmişse)
            if (ModelState.IsValid)
            {
                db.Kisiler.Add(kisi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DogumYeriId = new SelectList(db.Sehirler.ToList(), "Id", "SehirAd");
            return View();
        }

        [HttpGet]//Yazmasan da get oluyor
        public ActionResult Ekle()
        {
            ViewBag.DogumYeriId = new SelectList(db.Sehirler.ToList(), "Id", "SehirAd");
            return View();
        }

        public ActionResult Sil(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kisi kisi = db.Kisiler.Find(id);

            if (kisi == null)
            {
                return HttpNotFound();
            }

            return View(kisi);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Sil(Kisi kisi)
        {
            db.Entry(kisi).State = EntityState.Deleted;
            db.SaveChanges();

            return RedirectToAction("Index");


        }

        public ActionResult Duzenle(int id)
        {
            ViewBag.DogumYeriId = new SelectList(db.Sehirler.ToList(), "Id", "SehirAd");
            return View(db.Kisiler.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Duzenle(Kisi kisi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kisi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DogumYeriId = new SelectList(db.Sehirler.ToList(), "Id", "SehirAd");
            return View();
        }

    }
}