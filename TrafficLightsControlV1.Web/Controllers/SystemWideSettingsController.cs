using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrafficLightsControlV1.Web.DbContexts;

namespace TrafficLightsControlV1.Web.Controllers
{
    public class SystemWideSettingsController : Controller
    {
        private TrafficLightsControlV1DbContext _context = new TrafficLightsControlV1DbContext();
        // GET: SystemWideSettings/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SystemWideSettings/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SystemWideSettings/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
