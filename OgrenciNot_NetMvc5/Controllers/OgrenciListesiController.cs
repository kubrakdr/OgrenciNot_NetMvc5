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

            return View();
        }

        public ActionResult YeniOgrenci(TBL_OGRENCILER ogr)
        {
            db.TBL_OGRENCILER.Add(ogr);
            db.SaveChanges();
            return View();
        }

        public ActionResult Index()
        {
            var ogrenciler = db.TBL_OGRENCILER.ToList();
            return View(ogrenciler);
        }
    }
}