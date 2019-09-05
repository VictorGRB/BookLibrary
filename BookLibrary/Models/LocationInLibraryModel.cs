using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookLibrary.Models
{
    public class LocationInLibraryModel
    {
        public Guid IDLocationInLibrary { get; set; }
        public string Name { get; set; }
        public int Floor { get; set; }
        public int Sector { get; set; }
        public string Shelf { get; set; }
    }
}