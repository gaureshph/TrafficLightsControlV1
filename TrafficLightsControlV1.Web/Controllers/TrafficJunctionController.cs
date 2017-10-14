using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrafficLightsControlV1.Web.DbContexts;
using TrafficLightsControlV1.Web.DomainModels;

namespace TrafficLightsControlV1.Web.Controllers
{
    public class TrafficJunctionController : Controller
    {
        private TrafficLightsControlV1DbContext _context = new TrafficLightsControlV1DbContext();
        // GET: TrafficJunction
        public ActionResult Index()
        {
            return View(_context.TrafficJunctions.ToList());
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
                _context.TrafficJunctions.Add(new TrafficJunction
                {
                    Id = Convert.ToInt32(collection["Id"]),
                    Name = collection["Name"]
                });
                _context.SaveChanges();

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
            return View(_context.TrafficJunctions.FirstOrDefault(lmb => lmb.Id == id));
        }

        // POST: TrafficJunction/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                _context.Entry(new TrafficJunction
                {
                    Id = Convert.ToInt32(collection["Id"]),
                    Name = collection["Name"]
                }).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
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
            return View(_context.TrafficJunctions.FirstOrDefault(lmb => lmb.Id == id));
        }

        // POST: TrafficJunction/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _context.Entry(new TrafficJunction
                {
                    Id = id
                }).State = System.Data.Entity.EntityState.Deleted;
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
                throw ex;
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
