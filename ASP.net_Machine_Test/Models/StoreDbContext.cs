using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebGrease.Css.Ast.Selectors;
using System.Data.Entity;
namespace ASP.net_Machine_Test.Models
{
    public class StoreDbContext :DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}