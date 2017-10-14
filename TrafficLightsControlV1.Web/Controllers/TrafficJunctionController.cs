using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrafficLightsControlV1.Web.DbContexts;

namespace TrafficLightsControlV1.Web.Controllers
{
    public class TrafficJunctionController : Controller
    {
        private TrafficLightsControlV1DbContext _context = new TrafficLightsControlV1DbContext();
        // GET: TrafficJunction
        public ActionResult Index()
        {
            return View();
        }

        // GET: TrafficJunction/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TrafficJunction/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TrafficJunction/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TrafficJunction/Edit/5
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

        // GET: TrafficJunction/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TrafficJunction/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
