using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _12DataMigration.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }

        public int MobileNo { get; set; }

    }
}