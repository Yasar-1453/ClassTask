using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal_Book_Product
{
    internal class Journal : Product
    {
        public string Company { get; set; }
        public Journal(string name, double price, string company) : base (name, price)
        {
            Company = company;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"{Company}";
        }


    }
}
