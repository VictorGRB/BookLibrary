﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookLibrary.Models
{
    public class LocationInLibraryModel
    {
        public Guid IDLocationInLibrary { get; set; }
        [Required(ErrorMessage ="Mandatory Field")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Mandatory Field")]
        public int ?Floor { get; set; }
        [Required(ErrorMessage = "Mandatory Field")]
        public int ?Sector { get; set; }
        [Required(ErrorMessage = "Mandatory Field")]
        public string Shelf { get; set; }
    }
}