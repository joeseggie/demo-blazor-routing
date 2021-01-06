using System.Collections.Generic;
using System.Collections;
using System;

namespace Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url 
        { 
            get
            {
                return $"products/{Id}";
            }
        }
    }

    public class Products
    {
        private static List<Data.Product> products = new List<Data.Product>()
        {
            new Data.Product(){ Id = 1, Name = "Test 1" },
            new Data.Product(){ Id = 2, Name = "Test 2" },
            new Data.Product(){ Id = 3, Name = "Test 3" },
            new Data.Product(){ Id = 4, Name = "Test 4" }
        };

        public static List<Data.Product> GetProducts()
        {
            return products;
        }

        public static Data.Product GetProduct(int id)
        {
            return GetProducts().SingleOrDefault(p => p.Id == id);
        }
    }
}