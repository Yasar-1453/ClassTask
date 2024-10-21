using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal_Book_Product
{
    internal class Book : Product
    {
        public string Author { get; set; }
        public string Genre { get; set; }
        public Book(string name, double price, string author, string genre) : base(name, price)
        {
            Author = author;
            Genre = genre;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"{Author}, {Genre}";  
        }
    }
}
