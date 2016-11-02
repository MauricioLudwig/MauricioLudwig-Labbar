using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V4_Laboration7
{
    public abstract class Product : ISellable
    {
        public int Price { get; set; }
        public string ProductInformation { get; set; }
        public string ProductName { get; set; }
        public bool InStock { get; set; }

        public virtual string ProductParameterLabels()
        {
            return String.Format("{0,-20}{1,-20}{2,-20}",
                "Product",
                "Price",
                "Stock");
        }

        public virtual string ProductParameterValues()
        {
            return String.Format("{0,-20}{1,-20}{2,-20}",
                ProductName,
                Price,
                InStock == true ? "In Stock" : "Out of Stock");
        }
    }
}