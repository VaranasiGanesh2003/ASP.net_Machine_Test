using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.net_Machine_Test.Models
{
    public class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public int categoryId { get; set; }
        public Category category { get; set; }
    }
}