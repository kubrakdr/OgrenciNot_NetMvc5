using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNot_NetMvc5.Models.EntitiyFramework;

namespace OgrenciNot_NetMvc5.Controllers
{
    public class OgrenciListesiController : Controller
    {
        // GET: OgrenciListesi
        DbMvcOkulEntities db = new DbMvcOkulEntities();
        [HttpGet]
        public ActionResult YeniOgrenci()
        {
            List<SelectListItem> degerler = (from i in db.TBL_KULUPLER.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KULUPAD,
                                                 Value = i.KULUPID.ToString()
                                             }).ToList();

            ViewBag.dgr = degerler;

            return View();
        }

        public ActionResult YeniOgrenci(TBL_OGRENCILER ogr)
        {
            var klp = db.TBL_KULUPLER.Where(m => m.KULUPID == ogr.TBL_KULUPLER.KULUPID).FirstOrDefault();
            ogr.TBL_KULUPLER = klp;

            db.TBL_OGRENCILER.Add(ogr);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            var ogrenciler = db.TBL_OGRENCILER.ToList();
            return View(ogrenciler);
        }
    }
}

//public ActionResult YeniOgrenci()
//{
//    List<SelectListItem> items = new List<SelectListItem>();
//    items.Add(new SelectListItem { Text = "Matematik", Value = "0" });
//    items.Add(new SelectListItem { Text = "Kimya", Value = "1" });
//    items.Add(new SelectListItem { Text = "Biyoloji", Value = "2" });
//    items.Add(new SelectListItem { Text = "fizik", Value = "3" });
//    items.Add(new SelectListItem { Text = "Türkçe", Value = "4" });
//    ViewBag.DersAd = items;
//    return View();
//}