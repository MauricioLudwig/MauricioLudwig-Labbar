using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V6_Laboration16.Repositories;
using V6_Laboration16.GUI;
using V6_Laboration16.Models;

namespace V6_Laboration16.Controllers
{
    class ProductController
    {

        public ListProductRepository listProductRepo { get; set; }
        public FileProductRepository fileProductRepo { get; set; }

        public ProductController()
        {
            listProductRepo = new ListProductRepository();
            fileProductRepo = new FileProductRepository();
        }

        public void Add_List()
        {
            listProductRepo.Add();
        }

        public void Add_File()
        {
            fileProductRepo.Add();
        }

        public void GetSingle_List()
        {
            int index = UI.PrintProductNames(listProductRepo.GetAll());
            var product = listProductRepo.Get(index - 1);
            TextAndColor.LineBreak();
            Console.WriteLine("Selected product");
            Console.WriteLine("\n{0}", product.PrintProductInfo());
            Console.ReadKey();
        }

        public void GetSingle_File()
        {
            int index = UI.PrintProductNames(fileProductRepo.GetAll());
            var product = fileProductRepo.Get(index - 1);
            TextAndColor.LineBreak();
            Console.WriteLine("Selected product");
            Console.WriteLine("\n{0}", product.PrintProductInfo());
            Console.ReadKey();
        }

        public void GetAll_List()
        {
            PrintProducts(listProductRepo.GetAll());
            Console.ReadKey();
        }

        public void GetAll_File()
        {
            PrintProducts(fileProductRepo.GetAll());
            Console.ReadKey();
        }

        public void Update_List()
        {
            PrintProducts(listProductRepo.GetAll());
            int index = UI.GetProductIndex("Product to be updated");
            var product = UI.UpdateProduct(listProductRepo.Get(index - 1));
            listProductRepo.Update(product);
        }

        public void Update_File()
        {
            PrintProducts(fileProductRepo.GetAll());
            int index = UI.GetProductIndex("Product to be updated");
            var product = UI.UpdateProduct(fileProductRepo.Get(index - 1));
            fileProductRepo.Update(product);
        }

        public void Delete_List()
        {
            PrintProducts(listProductRepo.GetAll());
            int index = UI.GetProductIndex("Product to delete");
            listProductRepo.Delete(index - 1);
        }

        public void Delete_File()
        {
            PrintProducts(fileProductRepo.GetAll());
            int index = UI.GetProductIndex("Product to delete");
            fileProductRepo.Delete(index - 1);
        }

        private void PrintProducts(List<Product> products)
        {
            UI.PrintProducts(products);
        }
    }
}
