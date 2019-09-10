using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookLibrary.ViewModels
{
    public class LocationInLibraryBooksViewModel
    {
        public string Name { get; set; }
        public int? Floor { get; set; }
        public int? Sector { get; set; }
        public string Shelf { get; set; }
        public List<BookModel> Books = new List<BookModel>();
    }
}