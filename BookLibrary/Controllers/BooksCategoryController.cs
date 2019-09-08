﻿using BookLibrary.Models;
using BookLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookLibrary.Controllers
{
    
    public class BooksCategoryController : Controller
    {
        private BookRepository booksRepository = new BookRepository();
        private Repository.BooksCategoryRepository booksCategoryRepository = new Repository.BooksCategoryRepository();
        // GET: BooksCategory
        public ActionResult Index()
        {
            List<Models.BooksCategoryModel> booksCategories = booksCategoryRepository.GetAllBookCategories();
            return View("Index",booksCategories);
        }

        // GET: BooksCategory/Details/5
        public ActionResult Details(Guid id)
        {
            Models.BooksCategoryModel booksCategoryModel = booksCategoryRepository.GetBookCategoryByID(id);
            return View("BooksCategoryDetails",booksCategoryModel);
        }

        // GET: BooksCategory/Create
        public ActionResult Create()
        {
            return View("CreateBooksCategory");
        }

        // POST: BooksCategory/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Models.BooksCategoryModel booksCategoryModel = new Models.BooksCategoryModel();
                UpdateModel(booksCategoryModel);
                booksCategoryRepository.InsertBookCategory(booksCategoryModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("CreateBooksCategory");
            }
        }

        // GET: BooksCategory/Edit/5
        public ActionResult Edit(Guid id)
        {
            Models.BooksCategoryModel booksCategoryModel = booksCategoryRepository.GetBookCategoryByID(id);
            return View("EditBooksCategory",booksCategoryModel);
        }

        // POST: BooksCategory/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Models.BooksCategoryModel booksCategoryModel = new Models.BooksCategoryModel();
                UpdateModel(booksCategoryModel);
                booksCategoryRepository.UpdateBookCategory(booksCategoryModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("EditBooksCategory");
            }
        }

        // GET: BooksCategory/Delete/5
        public ActionResult Delete(Guid id)
        {
            Models.BooksCategoryModel booksCategoryModel = booksCategoryRepository.GetBookCategoryByID(id);
            return View("DeleteBooksCategory",booksCategoryModel);
        }

        // POST: BooksCategory/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                List<BookModel> books = booksRepository.GetAllBooksByBooksCategory(id);
                foreach(BookModel book in books)
                {
                    booksRepository.DeleteBook(book.IDBook);
                }
                // TODO: Add delete logic here
                booksCategoryRepository.DeleteBookCategory(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("DeleteBooksCategory");
            }
        }
    }
}
