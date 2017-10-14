using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrafficLightsControlV1.Web.DbContexts;
using TrafficLightsControlV1.Web.DomainModels;

namespace TrafficLightsControlV1.Web.Controllers
{
    public class SystemWideSettingsController : Controller
    {
        private TrafficLightsControlV1DbContext _context = new TrafficLightsControlV1DbContext();
        // GET: SystemWideSettings/Details/5
        public ActionResult Details()
        {
            return View(_context.SystemWideSettings.FirstOrDefault());
        }

        // GET: SystemWideSettings/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_context.SystemWideSettings.FirstOrDefault(lmb => lmb.Id == id));
        }

        // POST: SystemWideSettings/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                _context.Entry(new SystemWideSetting
                {
                    Id = Convert.ToInt32(collection["Id"]),
                    IsActive = collection["IsActive"].ToString().Contains("true"),
                    Signal1Time = Convert.ToInt32(collection["Signal1Time"]),
                    Signal2Time = Convert.ToInt32(collection["Signal2Time"]),
                    Signal3Time = Convert.ToInt32(collection["Signal3Time"]),
                    Signal4Time = Convert.ToInt32(collection["Signal4Time"])
                }).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index", "TrafficJunction");
            }
            catch(Exception ex)
            {
                return View();
                throw ex;
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
