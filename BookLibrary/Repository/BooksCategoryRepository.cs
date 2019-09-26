using BookLibrary.Models;
using BookLibrary.Models.DBObjects;
using BookLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookLibrary.Repository
{
    public class BooksCategoryRepository
    {
        private Models.DBObjects.BookLibraryModelsDataContext booksLibraryDataContext;
        public BooksCategoryRepository()
        {
            this.booksLibraryDataContext = new Models.DBObjects.BookLibraryModelsDataContext();
        }
        public BooksCategoryRepository(Models.DBObjects.BookLibraryModelsDataContext booksLibraryDataContext)
        {
            this.booksLibraryDataContext = booksLibraryDataContext;
        }
        public BooksCategoryBooksViewModel GetBooksCategoryBooks(Guid booksCatID)
        {
            BooksCategoryBooksViewModel booksCategoryBooksViewModel = new BooksCategoryBooksViewModel();
            BooksCategory booksCategory = booksLibraryDataContext.BooksCategories.FirstOrDefault(x => x.IDBooksCategory == booksCatID);
            if (booksCategory != null)
            {
                booksCategoryBooksViewModel.Genre = booksCategory.Genre;
                booksCategoryBooksViewModel.ChildAppropriate = booksCategory.ChildAppropriate;
                IQueryable<Book> catBooks = booksLibraryDataContext.Books.Where(x => x.IDBooksCategory == booksCatID);

                foreach(Book dbBook in catBooks)
                {
                    Models.BookModel bookModel = new Models.BookModel();

                    bookModel.Name = dbBook.Name;
                    bookModel.Author = dbBook.Author;
                    bookModel.Publisher = dbBook.Publisher;
                    bookModel.NumberOfCopies = dbBook.NumberOfCopies;
                    bookModel.imageUrl = dbBook.imageUrl;

                    booksCategoryBooksViewModel.Books.Add(bookModel);
                }
            }
            return booksCategoryBooksViewModel;

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
        public void DeleteBookCategory(Guid ID)
        {
            Models.DBObjects.BooksCategory booksCategoryToDelete = booksLibraryDataContext.BooksCategories.FirstOrDefault(x => x.IDBooksCategory == ID);
            if (booksCategoryToDelete != null)
            {
                booksLibraryDataContext.BooksCategories.DeleteOnSubmit(booksCategoryToDelete);
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