using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookLibrary.Models
{
    public class BookModel
    {
        public Guid IDBook { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int NumberOfCopies { get; set; }

        public Guid IDBooksCategory { get; set; }
        public Guid IDLocationInLibrary { get; set; }
    }
}