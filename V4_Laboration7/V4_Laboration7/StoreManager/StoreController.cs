using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4_Laboration7.StoreManager
{
    class StoreController
    {

        public List<Product> Category {get; set; }
        
        public void PrintProducts(int category)
        {
            Console.Clear();
            Category = ListManager.ReturnCategory(category);
            int index = 1;
            int selectedProduct;
            Console.WriteLine("{0,-20}{1}", "Index", Category.FirstOrDefault().ProductParameterLabels());

            foreach (var product in Category)
            {
                Console.WriteLine("{0,-20}{1}", index++, product.ProductParameterValues());
                Console.WriteLine("{0,-20}{1}" + Environment.NewLine,
                    "",
                    product.ProductInformation);
            }

            Console.WriteLine("Press enter to return or select product (index) to view options.");
            Console.Write("Input: ");
            string input = Console.ReadLine();

            if (!(String.IsNullOrEmpty(input)))
            {
                try
                {
                    selectedProduct = int.Parse(input);
                    ProductOption(selectedProduct);                    
                }
                catch
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadKey();
                }
            }
        }

        public void AddProduct()
        {
            Console.Clear();

            string name;
            string info;
            int price;
            bool inStock;

            UI.Store.GetCommonProductProp(out name, out info, out price, out inStock);

            int product = UI.Store.GetProductType();

            switch (product)
            {

                case 1:

                    ArtificialOrgan newArtificialOrgan = new ArtificialOrgan();

                    newArtificialOrgan.ProductName = name;
                    newArtificialOrgan.ProductInformation = info;
                    newArtificialOrgan.Price = price;
                    newArtificialOrgan.IsNew = inStock;
                    newArtificialOrgan.Longevity = ErrorHandling.ValidateInput.Integer("Longevity: ");

                    ListManager.ArtificialOrganCtg.Add(newArtificialOrgan);
                    UI.Store.ProductAddedValidation(name);

                    break;

                case 2:

                    Electronics newElectronics = new Electronics();

                    newElectronics.ProductName = name;
                    newElectronics.ProductInformation = info;
                    newElectronics.Price = price;
                    newElectronics.IsNew = inStock;
                    newElectronics.Weight = ErrorHandling.ValidateInput.Integer("Weight: ");

                    ListManager.ElectronicsCtg.Add(newElectronics);
                    UI.Store.ProductAddedValidation(name);

                    break;

                case 3:

                    UploadKnowledge newUploadKnowledge = new UploadKnowledge();

                    newUploadKnowledge.ProductName = name;
                    newUploadKnowledge.ProductInformation = info;
                    newUploadKnowledge.Price = price;
                    newUploadKnowledge.IsNew = inStock;
                    newUploadKnowledge.DataTransferTime = ErrorHandling.ValidateInput.Integer("Data Transfer Time: ");

                    ListManager.UploadKnowledgeCtg.Add(newUploadKnowledge);
                    UI.Store.ProductAddedValidation(name);

                    break;

                default:
                    Console.WriteLine("Invalid input. Operation canceled.");
                    break;
            }
        }

        private void ProductOption(int selectedProduct)
        {
            Console.Clear();
            int action = UI.Store.PrintProductOptions(Category[selectedProduct - 1]);

            switch (action)
            {
                case 1:
                    Customer.shoppingCart.Add(Category[selectedProduct - 1]);
                    Console.WriteLine("Product added to shopping cart.");
                    break;
                case 2:

                    if (Category[selectedProduct - 1].GetType() == typeof(ArtificialOrgan))
                        ListManager.ArtificialOrganCtg.RemoveAt(selectedProduct - 1);
                    else if (Category[selectedProduct - 1].GetType() == typeof(Electronics))
                        ListManager.ElectronicsCtg.RemoveAt(selectedProduct - 1);
                    else if (Category[selectedProduct - 1].GetType() == typeof(UploadKnowledge))
                        ListManager.UploadKnowledgeCtg.RemoveAt(selectedProduct - 1);

                    Console.WriteLine("Product removed.");

                    break;
                default:
                    Console.WriteLine("Invalid input. Returning to menu.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
