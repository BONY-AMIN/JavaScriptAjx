using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JavaScriptAjx.Models
{
    public class AjaxContext:DbContext
    {
        public AjaxContext() : base("AJDb")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Sum> Sums { get; set; }
    }
}