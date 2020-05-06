using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _18AuthenticationAndAuthorization.Models
{
    public class AuthDbContext: DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }
    }
}