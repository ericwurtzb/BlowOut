using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    public class Rental
    {
        
        public int rentalID { get; set; }
        [DisplayName("Instrument")]
        public string rentalName { get; set; }
        [DisplayName("New Price")]
        public int newPrice { get; set; }
        [DisplayName("Used Price")]
        public int usedPrice { get; set; }
        public string picture { get; set; }
    }
}