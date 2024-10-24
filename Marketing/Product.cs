using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing
{
    internal class Product
    {
        public int No { get; set; }
        public string Name { get; set; }
        private double _price;

        public Product(string name, double price, Type type)
        {
            Name = name;
            _price = price;
            Type = type;
        }

        public Type Type { get; set; }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    throw new PriceMustBeGratherThanZeroExpection("pulsuz mal yoxdu burda");
                }
                else
                {
                    _price = value;
                }
            }
        }
    }
}