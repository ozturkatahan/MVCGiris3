using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGiris3.Controllers
{
    public class DenemeController : Controller
    {
        // GET: Deneme
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ortalama(int? a, int? b)
        {
            if (a.HasValue && b.HasValue)
            {
                ViewBag.sonuc = (a + b) / 2m;
            }
            return View();
        }
        // GET: Deneme/Topla?sayi1=3&sayi2=4
        public decimal Topla(decimal sayi1, decimal sayi2)
        {
            return sayi1 + sayi2;
        }

        public ActionResult Carp(decimal? sayi1, decimal? sayi2)
        {
            ViewBag.sayi1 = sayi1 == null
                ? ""
                : sayi1.Value.ToString("0.00", CultureInfo.InvariantCulture);

            ViewBag.sayi2 = sayi2 == null
                 ? ""
                 : sayi2.Value.ToString("0.00", CultureInfo.InvariantCulture);

            if (sayi1 == null || sayi2 == null)
            {
                ViewBag.hata = "Lütfen 2 adet sayı giriniz.";
            }

            else
            {
                ViewBag.sonuc = sayi1 * sayi2;
            }

            return View();
        }
    }
}