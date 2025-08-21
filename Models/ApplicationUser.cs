using Microsoft.AspNetCore.Identity;
using CATERINGMANAGEMENTSERVICE.Models;
using System.ComponentModel.DataAnnotations;

namespace CATERINGMANAGEMENTSERVICE.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public  string Fullname {  get; set; }

        [Required]
        public string Email {  get; set; }

        [Required]
        public string Package {  get; set; }

        [Required]
        public string Menu { get; set; }
        
        
    }
}
