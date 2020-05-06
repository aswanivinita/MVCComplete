using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _18AuthenticationAndAuthorization.Models
{
    public class AppUser
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$", ErrorMessage = "Invalid email format.")]

        public string EmailAddress { get; set; }
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength =8)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 8)]
        [Compare("Password")]
        [NotMapped]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }
        public string Roles { get; set; }

    }
}