using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.net_Machine_Test.Models
{
    public class Category
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public ICollection<Product> products { get; set; }
    }
}