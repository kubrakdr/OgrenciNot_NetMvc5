using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNot_NetMvc5.Models.EntitiyFramework;

namespace OgrenciNot_NetMvc5.Controllers
{
    public class NotlarController : Controller
    {
        // GET: Notlar
        DbMvcOkulEntities db = new DbMvcOkulEntities();

        public ActionResult Index()
        {
            var notlar = db.TBL_NOTLAR.ToList();

            return View(notlar);
        }
    }
}