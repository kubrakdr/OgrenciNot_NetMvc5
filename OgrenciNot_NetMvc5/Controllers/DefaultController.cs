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


    }
}