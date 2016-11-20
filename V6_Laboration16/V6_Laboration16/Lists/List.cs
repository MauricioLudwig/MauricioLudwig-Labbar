using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V6_Laboration16.Models;

namespace V6_Laboration16.Lists
{
    static class List
    {
        public static List<Product> Products { get; set; }

        static List()
        {
            Products = new List<Product>()
            {
                new Product() { Name = "Memory",    Price = 100, Category = Product.Categories.Hardware     },
                new Product() { Name = "Dropbox",   Price = 200, Category = Product.Categories.CloudStorage },
                new Product() { Name = "Battery",   Price = 300, Category = Product.Categories.Hardware     },
                new Product() { Name = "Defrager",  Price = 400, Category = Product.Categories.Software     },
                new Product() { Name = "Refractor", Price = 500, Category = Product.Categories.Software     }
            };
        }
    }
}
