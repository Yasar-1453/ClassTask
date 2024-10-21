using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal_Book_Product
{
    internal class Library
    {
        Product[] Product = new Product[0];

        public void AddProduct(Product p)
        {
            Array.Resize(ref Product, Product.Length + 1 );
            Product[Product.Length - 1] = p;
        }

        public void GetProductByPrice(double minPrice, double maxPrice)
        {


            foreach(Product p in Product)
            {
                if(p.Price < minPrice && p.Price > maxPrice )
                {
                    Console.WriteLine(p.Name);
                }
            }
        }

        public void GetProductsByName(string name)
        {
            foreach (Product p in Product)
            {
                if (p.Name == name)
                {
                    Console.WriteLine(p.Name);
                }
            }
        }
    }
}
