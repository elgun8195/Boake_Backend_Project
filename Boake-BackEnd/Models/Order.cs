using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Boake_BackEnd.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public string Country { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Apartment { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string ZipCode { get; set; }


        [Required]
        public decimal TotalPrice { get; set; }
        [Required]
        public DateTime Date { get; set; } 
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
