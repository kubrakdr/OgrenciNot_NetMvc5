using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNot_NetMvc5.Models.EntitiyFramework;

namespace OgrenciNot_NetMvc5.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbMvcOkulEntities db = new DbMvcOkulEntities();
        public ActionResult Index()
        {
            var dersler = db.TBL_DERSLER.ToList();
            return View(dersler);
        }
        [HttpGet]
       public ActionResult YeniDers()
        {

            return View();
        }
        
       [HttpPost]
        public ActionResult YeniDers(TBL_DERSLER drs)
        {
            db.TBL_DERSLER.Add(drs);
            db.SaveChanges();
            return View();
        }

        public ActionResult Sil(int id)
        {
            var ders = db.TBL_DERSLER.Find(id);
            db.TBL_DERSLER.Remove(ders);
            db.SaveChanges();

            return RedirectToAction("Index");

        }

        public ActionResult DersGetir(int id)
        {
            var ders = db.TBL_DERSLER.Find(id);
            return View("DersGetir",ders);
        }
        public ActionResult Guncelle(TBL_DERSLER p)
        {
            var drs = db.TBL_DERSLER.Find(p.DERSID);
            drs.DERSAD = p.DERSAD;
            db.SaveChanges();

            return RedirectToAction("Index", "Default");


        }

    }
}