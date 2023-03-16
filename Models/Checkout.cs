using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission09_bshorne.Models
{
    public class Checkout
    {
        [Key]
        [BindNever]
        public int CheckoutId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage ="Please Enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the first address line")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        [Required(ErrorMessage = "Please enter your City")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter your State")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter your Zip Code")]
        public string Zip { get; set; }
        [Required(ErrorMessage = "Please enter your country")]
        public string Country { get; set; }
    }
}
