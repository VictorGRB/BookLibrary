using BookLibrary.Models;
using BookLibrary.Models.DBObjects;
using BookLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookLibrary.Repository
{
    public class BookRepository
    {
        
        private Models.DBObjects.BookLibraryModelsDataContext booksLibraryDataContext;
        public BookRepository()
        {
            this.booksLibraryDataContext = new Models.DBObjects.BookLibraryModelsDataContext();
        }
        public BookRepository(Models.DBObjects.BookLibraryModelsDataContext booksLibraryDataContext)
        {
            this.booksLibraryDataContext = booksLibraryDataContext;
        }
        

    
    public BookViewModel GetBookView(Guid bookID)
    {
        BookViewModel bookViewModel = new BookViewModel();
        Book book = booksLibraryDataContext.Books.FirstOrDefault(x => x.IDBook == bookID);
        if (book != null)
        {
            bookViewModel.IDBook = book.IDBook;
            bookViewModel.Name = book.Name;
            bookViewModel.Author = book.Author;
            bookViewModel.Publisher = book.Publisher;
            bookViewModel.NumberOfCopies = book.NumberOfCopies;
            bookViewModel.IDBooksCategory = book.IDBooksCategory;
            bookViewModel.IDLocationInLibrary = book.IDLocationInLibrary;
            bookViewModel.imageUrl = book.imageUrl;
            IQueryable<BooksCategory> booksCategories = booksLibraryDataContext.BooksCategories.Where(x => x.IDBooksCategory == bookID);
            foreach (BooksCategory dbBooksCategory in booksCategories)
            {
                Models.BooksCategoryModel booksCategoryModel = new Models.BooksCategoryModel();
                booksCategoryModel.IDBooksCategory = dbBooksCategory.IDBooksCategory;
                booksCategoryModel.Genre = dbBooksCategory.Genre;

                bookViewModel.BooksCategories.Add(booksCategoryModel);
            }
        }
        return bookViewModel;
    }

    public List<BookModel>GetAllBooksByBooksCategory(Guid id)
        {
            List<BookModel> booksList = new List<BookModel>();
            List<Book> book = booksLibraryDataContext.Books.Where(x => x.IDBooksCategory == id).ToList();
            foreach(Models.DBObjects.Book dbBook in book)
            {
                BookModel bookModel = new BookModel();
                bookModel.IDBook = dbBook.IDBook;
                bookModel.Name = dbBook.Name;
                bookModel.Author = dbBook.Author;
                bookModel.Publisher = dbBook.Publisher;
                bookModel.NumberOfCopies = dbBook.NumberOfCopies;
                bookModel.IDBooksCategory = dbBook.IDBooksCategory;
                bookModel.IDLocationInLibrary = dbBook.IDLocationInLibrary;
                bookModel.imageUrl = dbBook.imageUrl;

                booksList.Add(bookModel);

            }
            return booksList;
        }
        public List<BookModel> GetAllBooksByLocationInLibrary(Guid id)
        {
            List<BookModel> booksList = new List<BookModel>();
            List<Book> book = booksLibraryDataContext.Books.Where(x => x.IDLocationInLibrary == id).ToList();
            foreach (Models.DBObjects.Book dbBook in book)
            {
                BookModel bookModel = new BookModel();
                bookModel.IDBook = dbBook.IDBook;
                bookModel.Name = dbBook.Name;
                bookModel.Author = dbBook.Author;
                bookModel.Publisher = dbBook.Publisher;
                bookModel.NumberOfCopies = dbBook.NumberOfCopies;
                bookModel.IDBooksCategory = dbBook.IDBooksCategory;
                bookModel.IDLocationInLibrary = dbBook.IDLocationInLibrary;
                bookModel.imageUrl = dbBook.imageUrl;

                booksList.Add(bookModel);

            }
            return booksList;
        }
            public List<BookModel> GetAllBooks()
        {
            List<BookModel> bookList = new List<BookModel>();
            foreach (Models.DBObjects.Book dbBook in booksLibraryDataContext.Books)
            {
                bookList.Add(MapDbObjectToModel(dbBook));
            }
            return bookList;
        }
        public BookModel GetBookByID(Guid ID)
        {
            return MapDbObjectToModel(booksLibraryDataContext.Books.FirstOrDefault(x => x.IDBook == ID));
        }
        public void InsertBook(BookModel bookModel)
        {
            bookModel.IDBook = Guid.NewGuid();
            booksLibraryDataContext.Books.InsertOnSubmit(MapModelToDbObject(bookModel));
            booksLibraryDataContext.SubmitChanges();
        }
        public void DeductBook(Guid IDbook)
        {
            BookModel bookModel = GetBookByID(IDbook);
            if (bookModel.NumberOfCopies > 0)
            {
                bookModel.NumberOfCopies--;
                UpdateBook(bookModel);
            }
        }
        public void AddBook(Guid IDbook)
        {
            BookModel bookModel = GetBookByID(IDbook);
            if (bookModel.NumberOfCopies < 10)
            {
                bookModel.NumberOfCopies++;
                UpdateBook(bookModel);
            }
        }
        public void UpdateBook(BookModel bookModel)
        {
            Models.DBObjects.Book existingBook = booksLibraryDataContext.Books.FirstOrDefault(x => x.IDBook == bookModel.IDBook);
            if (existingBook != null)
            {
                existingBook.IDBook = bookModel.IDBook;
                existingBook.Name = bookModel.Name;
                existingBook.Author = bookModel.Author;
                existingBook.Publisher = bookModel.Publisher;
                existingBook.NumberOfCopies = bookModel.NumberOfCopies;
                existingBook.IDBooksCategory = bookModel.IDBooksCategory;
                existingBook.IDLocationInLibrary = bookModel.IDLocationInLibrary;
                existingBook.imageUrl = bookModel.imageUrl;
                booksLibraryDataContext.SubmitChanges();
            }
        }
        public void DeleteBook(Guid ID)
        {
            Models.DBObjects.Book bookToDelete = booksLibraryDataContext.Books.FirstOrDefault(x => x.IDBook == ID);
            if (bookToDelete != null)
            {
                booksLibraryDataContext.Books.DeleteOnSubmit(bookToDelete);
                booksLibraryDataContext.SubmitChanges();
            }
        }
        private BookModel MapDbObjectToModel(Models.DBObjects.Book dbBook)
        {
            BookModel bookModel = new BookModel();
            if (dbBook != null)
            {
                bookModel.IDBook = dbBook.IDBook;
                bookModel.Name = dbBook.Name;
                bookModel.Author = dbBook.Author;
                bookModel.Publisher = dbBook.Publisher;
                bookModel.NumberOfCopies = dbBook.NumberOfCopies;
                bookModel.IDBooksCategory = dbBook.IDBooksCategory;
                bookModel.IDLocationInLibrary = dbBook.IDLocationInLibrary;
                bookModel.imageUrl = dbBook.imageUrl;

                return bookModel;
            }
            return null;
        }
        private Models.DBObjects.Book MapModelToDbObject(BookModel bookModel)
        {
            Models.DBObjects.Book dbBookModel = new Models.DBObjects.Book();
            if (bookModel != null)
            {
                dbBookModel.IDBook = bookModel.IDBook;
                dbBookModel.Name = bookModel.Name;
                dbBookModel.Author = bookModel.Author;
                dbBookModel.Publisher = bookModel.Publisher;
                dbBookModel.NumberOfCopies = bookModel.NumberOfCopies;
                dbBookModel.IDBooksCategory = bookModel.IDBooksCategory;
                dbBookModel.IDLocationInLibrary = bookModel.IDLocationInLibrary;
                dbBookModel.imageUrl = bookModel.imageUrl;

                return dbBookModel;
            }
            return null;
        }


    }
}