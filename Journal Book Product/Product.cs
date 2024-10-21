using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal_Book_Product
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; } 

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string GetInfo()
        {
            return $"{Name}, {Price}";
        }

    }
}
