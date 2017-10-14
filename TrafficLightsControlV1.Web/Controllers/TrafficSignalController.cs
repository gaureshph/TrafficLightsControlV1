using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrafficLightsControlV1.Web.DomainModels;

namespace TrafficLightsControlV1.Web.Controllers
{
    public class TrafficSignalController : Controller
    {
        // GET: TrafficSignal
        public ActionResult Index()
        {
            return View();
        }

        // GET: TrafficSignal/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TrafficSignal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TrafficSignal/Create
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

        // GET: TrafficSignal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TrafficSignal/Edit/5
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

        // GET: TrafficSignal/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TrafficSignal/Delete/5
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
    }
}
