using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookLibrary.Controllers
{
    public class LocationInLibraryController : Controller
    {
        private Repository.LocationInLibraryRepository locationInLibraryRepository = new Repository.LocationInLibraryRepository();
        // GET: LocationInLibrary
        public ActionResult Index()
        {
            return View();
        }

        // GET: LocationInLibrary/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LocationInLibrary/Create
        public ActionResult Create()
        {
            return View("CreateLocationInLibrary");
        }

        // POST: LocationInLibrary/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Models.LocationInLibraryModel locationInLibraryModel= new Models.LocationInLibraryModel();
                UpdateModel(locationInLibraryModel);
                locationInLibraryRepository.InsertLocationInLibrary(locationInLibraryModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("CreateLocationInLibrary");
            }
        }

        // GET: LocationInLibrary/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LocationInLibrary/Edit/5
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

        // GET: LocationInLibrary/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LocationInLibrary/Delete/5
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
