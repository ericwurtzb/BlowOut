using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table("Rentals")]
    public class Rental
    {
        [Key]
        public int rentalID { get; set; }
        [DisplayName("Instrument")]
        public string RentalName { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string Picture { get; set; }
        public int ClientID { get; set; }
    }
}