﻿using RecipeMarket.DAL;
using RecipeMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecipeMarket.Controllers
{
    public class HomeController : Controller
    {
        private PrzepisyContext db = new PrzepisyContext();

        public ActionResult Index()
        {
            IQueryable<Przepis> przepisy = db.Przepisy.Take(10);

            ViewBag.Odpowiedz = "Ostatnie przepisy";

            return View(przepisy);
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}