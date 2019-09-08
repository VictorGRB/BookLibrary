using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookLibrary.Models
{
    public class BorrowFormModel
    {
        public Guid IDBorrowForm { get; set; }
        public Guid IDBook { get; set; }
        public Guid IDCustomer { get; set; }
        [Required(ErrorMessage ="Mandatory Field")]
        public DateTime BorrowedFrom { get; set; }
        [Required(ErrorMessage = "Mandatory Field")]
        public DateTime BorrowedUntil { get; set; }
        public bool ReturnedOnTime { get; set; }
        public bool ProperConditionsReturn { get; set; }
    }
}