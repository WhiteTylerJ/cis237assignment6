﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cis237Assignment6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Assignment 6 - Beverage Database Details";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact the creator";

            return View();
        }
    }
}