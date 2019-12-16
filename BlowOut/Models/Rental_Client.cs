using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    public class Rental_Client
    {
        public Rental rental { get; set; }
        public Client client { get; set; }
    }
}