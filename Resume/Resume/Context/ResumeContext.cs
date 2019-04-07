using Resume.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Resume.Context
{
    public class ResumeContext :DbContext
    {
        public DbSet<blog> Blogs { get; set; }
        public DbSet<post> Posts { get; set; }  
    }
}