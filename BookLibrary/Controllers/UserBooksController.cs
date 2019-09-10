using BookLibrary.Models;
using BookLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookLibrary.Controllers
{

    public class UserBooksController : Controller
    {
        private BookRepository bookRepository = new BookRepository();
        // GET: UserBooks
        public ActionResult Index()
        {
            List<BookModel> bookList = bookRepository.GetAllBooks();
            return View("Index", bookList);
        }

        // GET: UserBooks/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserBooks/Create
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

        // GET: UserBooks/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserBooks/Edit/5
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

        // GET: UserBooks/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserBooks/Delete/5
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
