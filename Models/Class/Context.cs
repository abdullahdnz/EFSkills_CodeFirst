using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EFSkills_CodeFirst.Models.Class
{
    public class Context : DbContext
    {
        public DbSet<Yetenek> Yeteneks { get; set; }
    }
}