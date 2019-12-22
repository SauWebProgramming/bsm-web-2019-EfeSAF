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
    public class KimlikController : Controller
    {
        KDBContext db = new KDBContext();
        // GET: Kimlik
        public ActionResult Index()
        {
            return View(db.Kimlik.ToList());
        }

            
        public ActionResult Edit(int id)
        {
            var Kimlik = db.Kimlik.Where(x => x.KimlikId == id).SingleOrDefault(); //gelen id ye göre kontrol ile nerden geldiği
            return View(Kimlik);
        }

        // POST: Kimlik/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken] //güvenlik için edit kısmıyla bağlantı
        public ActionResult Edit(int id, Kimlik Kimlik,HttpPostedFileBase LogoURL)
        {
            if(ModelState.IsValid)
            {
                var k = db.Kimlik.Where(x => x.KimlikId == id).SingleOrDefault();
                
                if(LogoURL !=null)
                {
                    if(System.IO.File.Exists(Server.MapPath(Kimlik.LogoURL))) //önceden kaydedilen dosya kontrolü
                    {
                        System.IO.File.Delete(Server.MapPath(Kimlik.LogoURL)); //önceki resmi silme durumu
                    }
                    WebImage img = new WebImage(LogoURL.InputStream); //yeni dosya yükleme
                    FileInfo imginfo = new FileInfo(LogoURL.FileName);

                    string logoname = LogoURL.FileName+ imginfo.Extension;
                    img.Resize(300, 200);
                    img.Save("~/Uploads/Kimlik/");
                    k.LogoURL = "/Uploads/Kimlik/" + logoname;
                }
                k.Title = Kimlik.Title;
                k.Keywords = Kimlik.Keywords;
                k.Description = Kimlik.Description;
                k.Unvan = Kimlik.Unvan;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Kimlik);
        }  
        
    }
}
