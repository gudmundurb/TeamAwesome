﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SozialWeb.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			// If you want to display a list of the currently logged
			// in users friends, you could use the FriendService
			// to do that.
			return View();
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