using BookLibrary.Models;
using BookLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace BookLibrary.Controllers
{

    public class BookController : Controller
    {
        private BorrowFormRepository borrowFormsRepository = new BorrowFormRepository();
        private LocationInLibraryRepository locationInLibraryRepository = new LocationInLibraryRepository();
        private BooksCategoryRepository booksCategoryRepository = new BooksCategoryRepository();
        private Repository.BookRepository bookRepository = new Repository.BookRepository();
        // GET: Book
        public ActionResult Index(string searchBy,string search)
        {
            List<Models.BookModel> books = bookRepository.GetAllBooks();
            
            if (searchBy =="Name")
            {
                return View(books.Where(x => x.Name.IndexOf (search,StringComparison.OrdinalIgnoreCase)>0 || search == null).ToList());
            }
            else if(searchBy =="Author")
            {
                return View(books.Where(x => x.Author.IndexOf (search, StringComparison.OrdinalIgnoreCase) > 0 || search == null).ToList());
            }
            
            else
            {
                return View("Index", books);
            }

        }

        // GET: Book/Details/5
        public ActionResult Details(Guid id)
        {
            Models.BookModel bookModel = bookRepository.GetBookByID(id);
            return View("BookDetails", bookModel);

        }
        [Authorize(Roles = "Admin")]
        // GET: Book/Create
        public ActionResult Create()
        {
            var bookCategories = booksCategoryRepository.GetAllBookCategories();
            SelectList lst = new SelectList(bookCategories, "IDBooksCategory", "Genre");
            ViewData["bookCategory"] = lst;

            var locationsInLibrary = locationInLibraryRepository.GetAllLocationsInLibrary();
            SelectList locs = new SelectList(locationsInLibrary, "IDLocationInLibrary", "Name");
            ViewData["locationInLibrary"] = locs;

            return View("CreateBook");
        }
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(Guid id)
        {
            Models.BookModel bookModel = bookRepository.GetBookByID(id);
            return View("EditBook",bookModel);
        }
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        // GET: Book/Delete/5
        public ActionResult Delete(Guid id)
        {
            Models.BookModel bookModel = bookRepository.GetBookByID(id);
            return View("DeleteBook",bookModel);
        }
        [Authorize(Roles = "Admin")]
        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                List<BorrowFormModel> borrowForms = borrowFormsRepository.GetAllBorrowFormsByBookId(id);
                foreach(BorrowFormModel borrowForm in borrowForms)
                {
                    borrowFormsRepository.DeleteBorrowForm(borrowForm.IDBorrowForm);
                }
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
