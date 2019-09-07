using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookLibrary.Models
{
    public class BooksCategoryModel
    {
        public Guid IDBooksCategory { get; set; }
        [Required(ErrorMessage ="Mandatory Field")]
        [StringLength(50,ErrorMessage ="String too long")]
        public string Genre { get; set; }
        public bool ChildAppropriate { get; set; }
    }
}