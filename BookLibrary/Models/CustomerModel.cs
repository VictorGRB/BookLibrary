using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookLibrary.Models
{
    public class CustomerModel
    {
        public Guid IDCustomer { get; set; }
        [Required(ErrorMessage ="Mandatory Field")]
        [StringLength(50,ErrorMessage ="Too many characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Mandatory Field")]
        [StringLength(50, ErrorMessage = "Too many characters")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Mandatory Field")]
        [StringLength(100, ErrorMessage = "Too many characters")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Mandatory Field")]
        [StringLength(20, ErrorMessage = "Too many characters")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Mandatory Field")]
        public DateTime CustomerSince { get; set; }
        [Required(ErrorMessage = "Mandatory Field")]
        public int BooksReturnedOnTime { get; set; }
        public bool MonthlyFeePayed { get; set; }
    }
}