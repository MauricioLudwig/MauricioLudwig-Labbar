using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V6_Laboration16.Models;
using V6_Laboration16.Lists;
using V6_Laboration16.GUI;

namespace V6_Laboration16.Repositories
{
    class ListProductRepository : IProductRepository
    {
        public void Add()
        {
            var newProduct = UI.AddProduct();
            List.Products.Add(newProduct);
        }

        public void Delete(int id)
        {
            List.Products.RemoveAt(id);
        }

        public Product Get(int id)
        {
            return List.Products[id];
        }

        public List<Product> GetAll()
        {
            return List.Products;
        }

        public void Update(Product updatedProduct)
        {
            List.Products.RemoveAt(List.Products.IndexOf(updatedProduct));
            List.Products.Add(updatedProduct);
        }
    }
}
