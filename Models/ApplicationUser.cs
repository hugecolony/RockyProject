using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace RockyProject.Models
{
    public class ApplicationUser : IdentityUser

    {
        [Required]
        public string FullName { get; set; }
        [NotMapped]
        
        public string City { get; set; }
        [NotMapped]
        public string State { get; set; }
        [NotMapped]
        public string StreetAddress { get; set; }
        [NotMapped]
        public string PostalCode { get; set; }

    }
}
