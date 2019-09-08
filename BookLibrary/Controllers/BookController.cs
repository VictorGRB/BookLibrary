using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookLibrary.Controllers
{
    public class BookController : Controller
    {
        private Repository.BookRepository bookRepository = new Repository.BookRepository();
        // GET: Book
        public ActionResult Index()
        {
            List<Models.BookModel> books = bookRepository.GetAllBooks();
            return View("Index",books);
        }

        // GET: Book/Details/5
        public ActionResult Details(Guid id)
        {
            Models.BookModel bookModel = bookRepository.GetBookByID(id);
            return View("BookDetails",bookModel);
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View("CreateBook");
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Models.BookModel bookModel = new Models.BookModel();
                UpdateModel(bookModel);
                bookRepository.InsertBook(bookModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("CreateBook");
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(Guid id)
        {
            Models.BookModel bookModel = bookRepository.GetBookByID(id);
            return View("EditBook",bookModel);
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Models.BookModel bookModel = new Models.BookModel();
                UpdateModel(bookModel);
                bookRepository.UpdateBook(bookModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("EditBook");
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(Guid id)
        {
            Models.BookModel bookModel = bookRepository.GetBookByID(id);
            return View("DeleteBook",bookModel);
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                bookRepository.DeleteBook(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("DeleteBook");
            }
        }
    }
}
