using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing
{
    internal class Store
    {
        Product[] Product = new Product[0];

        public void AddProduct(Product products)
        {
            Array.Resize(ref Product, Product.Length + 1);
            Product[Product.Length - 1] = products;
        }

        public void RemoveProduct(int no)
        {
            foreach (Product p in Product)
            {
                if (p.No == no)
                {
                    Array.Resize(ref Product, Product.Length - 1);
                    Product[Product.Length + 1] = p;
                }
            }
        }

        public void GetProduct (int? no)
        {
            foreach(Product p in Product)
            {
                if (p.No == no)
                {
                    Console.WriteLine($"Product {Product}");
                }
            }
        }

        public Product[] FilterProductsByType(Type type)
        {
            Product[] filteredProduct = new Product[0];

            foreach (Product p in Product)
            {
                if(p.Type == type)
                {
                    Array.Resize(ref filteredProduct , filteredProduct.Length+1);
                    filteredProduct[filteredProduct.Length-1] = p;
                    Console.WriteLine($"Name: {p.Name}, price: {p.Price}");
                }
            }
            return filteredProduct;
        }

        public Product[] FilterProductsByName(string name)
        {
            Product[] filteredProduct = new Product[0];

            foreach (Product p in Product)
            {
                if (p.Name == name)
                {
                    Array.Resize(ref filteredProduct , filteredProduct.Length+1);
                    filteredProduct[filteredProduct.Length - 1] = p;
                    Console.WriteLine($"Name: {p.Type}, price: {p.Price}");
                }
            }
            return filteredProduct;
        }
    }
}
