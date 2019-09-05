﻿using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookLibrary.Repository
{
    public class BooksCategoryRepository
    {
        private Models.DBObjects.BooksLibraryDataContext booksLibraryDataContext;
        public BooksCategoryRepository()
        {
            this.booksLibraryDataContext = new Models.DBObjects.BooksLibraryDataContext();
        }
        public BooksCategoryRepository(Models.DBObjects.BooksLibraryDataContext booksLibraryDataContext)
        {
            this.booksLibraryDataContext = booksLibraryDataContext;
        }
        public List<BooksCategoryModel> GetAllBookCategories()
        {
            List<BooksCategoryModel> bookCategoriesList = new List<BooksCategoryModel>();
            foreach(Models.DBObjects.BooksCategory dbbookCategory in booksLibraryDataContext.BooksCategories)
            {
                bookCategoriesList.Add(MapDbObjectToModel(dbbookCategory));
            }
            return bookCategoriesList;
        }
        public BooksCategoryModel GetBookCategoryByID(Guid ID)
        {
            return MapDbObjectToModel(booksLibraryDataContext.BooksCategories.FirstOrDefault(x => x.IDBooksCategory == ID));
        }
        public void InsertBookCategory(BooksCategoryModel booksCategoryModel)
        {
            booksCategoryModel.IDBooksCategory = Guid.NewGuid();
            booksLibraryDataContext.BooksCategories.InsertOnSubmit(MapModelToDbObject(booksCategoryModel));
            booksLibraryDataContext.SubmitChanges();
        }
        public void UpdateBookCategory(BooksCategoryModel booksCategoryModel)
        {
            Models.DBObjects.BooksCategory existingBooksCategory = booksLibraryDataContext.BooksCategories.FirstOrDefault(x => x.IDBooksCategory == booksCategoryModel.IDBooksCategory);
            if (existingBooksCategory != null)
            {
                existingBooksCategory.IDBooksCategory = booksCategoryModel.IDBooksCategory;
                existingBooksCategory.Genre = booksCategoryModel.Genre;
                existingBooksCategory.ChildAppropriate = booksCategoryModel.ChildAppropriate;
                booksLibraryDataContext.SubmitChanges();
            }
        }
        private BooksCategoryModel MapDbObjectToModel(Models.DBObjects.BooksCategory dbbookCategory)
        {
            BooksCategoryModel booksCategoryModel = new BooksCategoryModel();
            if (dbbookCategory != null)
            {
                booksCategoryModel.IDBooksCategory = dbbookCategory.IDBooksCategory;
                booksCategoryModel.Genre = dbbookCategory.Genre;
                booksCategoryModel.ChildAppropriate = dbbookCategory.ChildAppropriate;

                return booksCategoryModel;
            }
            return null;
        }
        private Models.DBObjects.BooksCategory MapModelToDbObject(BooksCategoryModel booksCategoryModel)
        {
            Models.DBObjects.BooksCategory dbbookCategoryModel = new Models.DBObjects.BooksCategory();
            if (booksCategoryModel != null)
            {
                dbbookCategoryModel.IDBooksCategory = booksCategoryModel.IDBooksCategory;
                dbbookCategoryModel.Genre = booksCategoryModel.Genre;
                dbbookCategoryModel.ChildAppropriate = booksCategoryModel.ChildAppropriate;

                return dbbookCategoryModel;
            }
            return null;
        }


    }
}