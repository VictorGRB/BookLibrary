using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookLibrary.Models
{
    public class BooksCategoryModel
    {
        public Guid IDBooksCategory { get; set; }
        public string Genre { get; set; }
        public bool ChildAppropriate { get; set; }
    }
}