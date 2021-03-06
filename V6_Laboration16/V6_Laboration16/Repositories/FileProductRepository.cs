﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V6_Laboration16.Models;
using System.IO;
using Newtonsoft.Json;
using V6_Laboration16.GUI;

namespace V6_Laboration16.Repositories
{
    class FileProductRepository : IProductRepository
    {

        private List<Product> products;
        private string file;

        public FileProductRepository()
        {
            var directory = Environment.CurrentDirectory;
            file = String.Format("{0}{1}", directory, @"\data.json");

            if (!(Directory.Exists(directory)))
                Directory.CreateDirectory(directory);

            if ((!File.Exists(file)))
                File.Create(file).Close();

            var jsonFromFile = File.ReadAllText(file);

            if (!(String.IsNullOrEmpty(jsonFromFile) || jsonFromFile == "null"))
            {
                products = JsonConvert.DeserializeObject<List<Product>>(jsonFromFile);
            }
            else
            {
                products = new List<Product>()
                    {
                        new Product { Name = "Computer", Price = 2500, Category = Product.Categories.Hardware }
                    };
            }

            UpdateFile();
        }

        public void Add()
        {
            var newProduct = UI.AddProduct();
            products.Add(newProduct);
            UpdateFile();
        }

        public void Delete(int id)
        {
            products.RemoveAt(id);
            UpdateFile();
        }

        public Product Get(int id)
        {
            return products[id];
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public void Update(Product updatedProduct)
        {
            products.RemoveAt(products.IndexOf(updatedProduct));
            products.Add(updatedProduct);
            UpdateFile();
        }

        private void UpdateFile()
        {
            string jsonString = JsonConvert.SerializeObject(products);
            File.WriteAllText(file, jsonString);

            var jsonFromFile = File.ReadAllText(file);
            products = JsonConvert.DeserializeObject<List<Product>>(jsonFromFile);
        }
    }
}
