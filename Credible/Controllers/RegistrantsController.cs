using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Credible.Controllers
{
    public class RegistrantsController : Controller
    {
        // GET: Registrants
        public ActionResult Index()
        {
            return View();
        }

        // GET: Registrants/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Registrants/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registrants/Create
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

        // GET: Registrants/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Registrants/Edit/5
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

        // GET: Registrants/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Registrants/Delete/5
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
