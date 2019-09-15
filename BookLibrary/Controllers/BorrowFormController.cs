using BookLibrary.Models;
using BookLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookLibrary.Controllers
{
    public class BorrowFormController : Controller
    {
        private BookRepository bookRepository = new BookRepository();
        private CustomerRepository customerRepository = new CustomerRepository();
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
            //bookRepository.DeductBook(id);
            Models.BorrowFormModel borrowFormModel = borrowFormRepository.GetBorrowFormByID(id);
            return View("BorrowFormDetails",borrowFormModel);
        }
        [Authorize(Roles = "Admin")]
        // GET: BorrowForm/Create
        public ActionResult Create()
        {
            var books = bookRepository.GetAllBooks();
            SelectList bks = new SelectList(books, "IDBook", "Name");
            ViewData["book"] = bks;

            var customers = customerRepository.GetAllCustomers();
            SelectList cust = new SelectList(customers, "IDCustomer", "Name");
            ViewData["customer"] = cust;
            return View("CreateBorrowForm");
        }
        [Authorize(Roles = "Admin")]
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
        
       
        [Authorize(Roles = "Admin")]
        // GET: BorrowForm/Edit/5
        public ActionResult Edit(Guid id)
        {
            Models.BorrowFormModel borrowFormModel = borrowFormRepository.GetBorrowFormByID(id);
            return View("EditBorrowForm",borrowFormModel);
        }
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        // GET: BorrowForm/Delete/5
        public ActionResult Delete(Guid id)
        {
            Models.BorrowFormModel borrowFormModel = borrowFormRepository.GetBorrowFormByID(id);
            return View("DeleteBorrowForm",borrowFormModel);
        }
        [Authorize(Roles = "Admin")]
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
