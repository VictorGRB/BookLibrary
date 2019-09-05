using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookLibrary.Models
{
    public class BorrowFormModel
    {
        public Guid IDBorrowForm { get; set; }
        public Guid IDBook { get; set; }
        public Guid IDCustomer { get; set; }
        public DateTime BorrowedFrom { get; set; }
        public DateTime BorrowedUntil { get; set; }
        public bool ReturnedOnTime { get; set; }
        public bool ProperConditionsReturn { get; set; }
    }
}