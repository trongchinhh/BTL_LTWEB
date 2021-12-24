﻿using BTL_10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTL_10.Controllers
{
    public class HomeController : Controller
    {
        TourStore db = new TourStore();
        public ActionResult Index()
        {
            ViewBag.tourNew= db.TOURs.OrderByDescending(t => t.NGAYBD).Take(5);
            ViewBag.tour = db.TOURs.OrderBy(t => t.GIA).Take(5);
            ViewBag.blog = db.BLOGs.ToList().Take(3);
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }
    }
}