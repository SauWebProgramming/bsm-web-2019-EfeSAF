using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProje.Models;
using WebProje.Models.DataContext;
using WebProje.Models.Model;

namespace WebProje.Controllers
{
    public class AdminController : Controller
    {
        KDBContext db = new KDBContext();
        
        // GET: Admin
        public ActionResult Index()
        {
            var sorgu = db.Kategori.ToList();
            
            return View(sorgu);
        }
        public ActionResult Login()
        {
            return View();
        }
    }
    



}