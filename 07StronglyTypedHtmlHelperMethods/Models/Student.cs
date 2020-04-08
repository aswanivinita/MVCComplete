using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _07StronglyTypedHtmlHelperMethods.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Branch { get; set; }

        public string Description { get; set; }
        public bool NeedHostel { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}