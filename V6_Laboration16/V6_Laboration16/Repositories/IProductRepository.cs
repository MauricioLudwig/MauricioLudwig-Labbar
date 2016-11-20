using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V6_Laboration16.Models;

namespace V6_Laboration16.Repositories
{
    interface IProductRepository
    {
        void Add();
        Product Get(int id);
        List<Product> GetAll();
        void Update(Product updatedProduct);
        void Delete(int id);
    }
}
