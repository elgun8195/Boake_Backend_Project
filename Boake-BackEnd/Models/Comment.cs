using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Boake_BackEnd.Models
{
    public class Comment:BaseEntity
    {
       
        [Required]
        [StringLength(maximumLength: 200)]
        public string Message { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public bool IsAccess { get; set; }
        public int? BlogId { get; set; }
        public Blog Blog { get; set; } 
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
