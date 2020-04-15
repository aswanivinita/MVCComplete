using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _10DataAnnotations.Models
{
    public class Student
    {

        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email{ get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [Compare("Password")]
        [NotMapped]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }
        
        [Required (ErrorMessage = "The range must be between 0 and 600")]
        [Range (0,600)]
        [DisplayName("Total Marks")]
        public int TotalMarks { get; set; }

    }
}