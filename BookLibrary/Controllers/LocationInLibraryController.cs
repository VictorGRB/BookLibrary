﻿using System;
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
            List<Models.LocationInLibraryModel> locationsInLibrary = locationInLibraryRepository.GetAllLocationsInLibrary();
            return View("Index",locationsInLibrary);
        }

        // GET: LocationInLibrary/Details/5
        public ActionResult Details(Guid id)
        {
            Models.LocationInLibraryModel locationInLibraryModel = locationInLibraryRepository.GetLocationInLibraryByID(id);
            return View("LocationInLibraryDetails",locationInLibraryModel);
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
                Models.LocationInLibraryModel locationInLibraryModel = new Models.LocationInLibraryModel();
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
        public ActionResult Edit(Guid id)
        {
            Models.LocationInLibraryModel locationInLibraryModel = locationInLibraryRepository.GetLocationInLibraryByID(id);
            return View("EditLocationInLibrary",locationInLibraryModel);
        }

        // POST: LocationInLibrary/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Models.LocationInLibraryModel locationInLibraryModel = new Models.LocationInLibraryModel();
                UpdateModel(locationInLibraryModel);
                locationInLibraryRepository.UpdateLocationInLibrary(locationInLibraryModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("EditLocationInLibrary");
            }
        }

        // GET: LocationInLibrary/Delete/5
        public ActionResult Delete(Guid id)
        {
            Models.LocationInLibraryModel locationInLibraryModel = locationInLibraryRepository.GetLocationInLibraryByID(id);
            return View("DeleteLocationInLibrary",locationInLibraryModel);
        }

        // POST: LocationInLibrary/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                locationInLibraryRepository.DeleteLocationInLibrary(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("DeleteLocationInLibrary");
            }
        }
    }
}
