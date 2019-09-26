using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookLibrary.ViewModels
{
    public class BooksCategoryBooksViewModel
    {
        public string Genre { get; set; }
        public bool ChildAppropriate { get; set; }
        public List<BookModel> Books = new List<BookModel>();

    }
}