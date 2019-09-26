using BookLibrary.Models;
using BookLibrary.Models.DBObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookLibrary.ViewModels
{
    public class BookViewModel
    {
        public Guid IDBook { get; set; }
        [Required(ErrorMessage = "Mandatory Field")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Mandatory Field")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Mandatory Field")]
        public string Publisher { get; set; }
        [Required(ErrorMessage = "Mandatory Field")]
        public int NumberOfCopies { get; set; }

        public Guid IDBooksCategory { get; set; }
        public Guid IDLocationInLibrary { get; set; }
        public string imageUrl { get; set; }
        public List<BooksCategoryModel> BooksCategories = new List<BooksCategoryModel>();
    }
}