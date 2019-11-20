using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table("Clients")]
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [MaxLength(6, ErrorMessage ="Zip must be 6 characters")]
        public string Zip { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone(ErrorMessage ="Enter in a phone number (xxx)xxx-xxxx")]
        public string Phone { get; set; }
    }
}