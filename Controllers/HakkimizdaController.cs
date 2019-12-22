using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using WebProje.Models.DataContext;
using WebProje.Models.Model;

namespace WebProje.Controllers
{
    public class HakkimizdaController : Controller
    {
        KDBContext db = new KDBContext();
        // GET: Hakkimizda
        public ActionResult Index()
        {
            var h = db.Hakkimizda.ToList();
            return View(h);
        }
        
        public ActionResult Edit(int id)
        {
            var h = db.Hakkimizda.Where(x => x.HakkimizdaId == id).FirstOrDefault();

            return View(h);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(int id,Hakkimizda h)
        {
            if (ModelState.IsValid)
            {
                var hakkimizda = db.Hakkimizda.Where(x => x.HakkimizdaId == id).SingleOrDefault();
                hakkimizda.Aciklama = h.Aciklama;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(h);
        }
    }
}