using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookLibrary.Controllers
{
    public class BorrowFormController : Controller
    {
        private Repository.BorrowFormRepository borrowFormRepository = new Repository.BorrowFormRepository();
        // GET: BorrowForm
        public ActionResult Index()
        {
            List<Models.BorrowFormModel> borrowForms = borrowFormRepository.GetAllBorrowForms();
            return View("Index",borrowForms);
        }

        // GET: BorrowForm/Details/5
        public ActionResult Details(Guid id)
        {
            Models.BorrowFormModel borrowFormModel = borrowFormRepository.GetBorrowFormByID(id);
            return View("BorrowFormDetails",borrowFormModel);
        }

        // GET: BorrowForm/Create
        public ActionResult Create()
        {
            return View("CreateBorrowForm");
        }

        // POST: BorrowForm/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Models.BorrowFormModel borrowFormModel = new Models.BorrowFormModel();
                UpdateModel(borrowFormModel);
                borrowFormRepository.InsertBorrowForm(borrowFormModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("CreateBorrowForm");
            }
        }

        // GET: BorrowForm/Edit/5
        public ActionResult Edit(Guid id)
        {
            Models.BorrowFormModel borrowFormModel = borrowFormRepository.GetBorrowFormByID(id);
            return View("EditBorrowForm",borrowFormModel);
        }

        // POST: BorrowForm/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Models.BorrowFormModel borrowFormModel = new Models.BorrowFormModel();
                UpdateModel(borrowFormModel);
                borrowFormRepository.UpdateBorrowForm(borrowFormModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("EditBorrowForm");
            }
        }

        // GET: BorrowForm/Delete/5
        public ActionResult Delete(Guid id)
        {
            Models.BorrowFormModel borrowFormModel = borrowFormRepository.GetBorrowFormByID(id);
            return View("DeleteBorrowForm",borrowFormModel);
        }

        // POST: BorrowForm/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                borrowFormRepository.DeleteBorrowForm(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("DeleteBorrowForm");
            }
        }
    }
}
