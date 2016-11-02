using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4_Laboration7.StoreManager
{
    class StoreController
    {

        public List<Product> Category { get; set; }

        public void SetCategory(int category)
        {
            Category = ListManager.ReturnCategory(category);
        }
        
        public void PrintProducts()
        {
            Console.Clear();
            Console.WriteLine("{0}", Category.FirstOrDefault().ProductParameterLabels());

            foreach (var product in Category)
            {
                Console.WriteLine("{0}", product.ProductParameterValues());
                Console.WriteLine("{0}" + Environment.NewLine,
                    product.ProductInformation);
            }

            Console.ReadKey();
        }

    }
}
