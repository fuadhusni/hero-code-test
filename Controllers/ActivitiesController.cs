using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hero_code_test.Controllers
{
	public class ActivitiesController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Search()
		{
			return View("Search");
		}
	}
}