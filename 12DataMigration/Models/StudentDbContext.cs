using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _12DataMigration.Models
{
    public class StudentDbContext :DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}