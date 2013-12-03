using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AOLHack.Domain;

namespace AOLHack.Site.Controllers
{
    public class ManagementController : Controller
    {
        //
        // GET: /Management/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListLocations()
        {
            var model = new AOLHackEntities();
            return View(model.Locations.ToList());
        }

    }
}
