using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Places.Models
{
    public class Place
    {
        public int PlaceID { get; set; }
        public string PlaceName { get; set; }
        public string ZipCode { get; set; }
        public int CountyID { get; set; }

        public virtual County County { get; set; }
    }
}