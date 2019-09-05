using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookLibrary.Models
{
    public class CustomerModel
    {
        public Guid IDCustomer { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CustomerSince { get; set; }
        public int BooksReturnedOnTime { get; set; }
        public bool MonthlyFeePayed { get; set; }
    }
}