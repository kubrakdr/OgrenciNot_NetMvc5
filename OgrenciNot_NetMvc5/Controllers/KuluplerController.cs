﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNot_NetMvc5.Models.EntitiyFramework;

namespace OgrenciNot_NetMvc5.Controllers
{
    public class KuluplerController : Controller
    {
        // GET: Kulupler
        DbMvcOkulEntities db = new DbMvcOkulEntities();

        [HttpGet]
        public ActionResult YeniKulup()
        {

            return View();
        }

        [HttpPost]
        public ActionResult YeniKulup(TBL_KULUPLER klp)
        {
            db.TBL_KULUPLER.Add(klp);
            db.SaveChanges();

            return View();
        }

        public ActionResult Index()
        {
            var kulupler = db.TBL_KULUPLER.ToList();

            return View(kulupler);
        }

        public ActionResult Sil(int id)
        {
            var kulup = db.TBL_KULUPLER.Find(id);
            db.TBL_KULUPLER.Remove(kulup);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult KulupGetir(int id)
        {
            var kulup = db.TBL_KULUPLER.Find(id);

            return View("KulupGetir",kulup);

        }
        public ActionResult Guncelle(TBL_KULUPLER p)
        {
            var klp = db.TBL_KULUPLER.Find(p.KULUPID);
            klp.KULUPAD = p.KULUPAD;
            db.SaveChanges();


            return RedirectToAction("Index","Kulupler") ;
        }


    }
}