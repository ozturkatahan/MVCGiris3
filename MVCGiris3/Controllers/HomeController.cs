using MVCGiris3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGiris3.Controllers
{
    public class HomeController : Controller
    {
        KisiContext db = new KisiContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Kisiler.ToList());
        }
    }
}