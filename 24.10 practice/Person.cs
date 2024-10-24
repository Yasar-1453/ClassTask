using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._10_practice
{
    internal class Person
    {
        public string FullName { get; set; }
        private sbyte _age;

        public sbyte Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0 && value < 125)
                {
                    _age = value;
                }
                else
                {
                    throw new InvalidAgeException("sen hele dogulmamisan ve ya olmusen");
                }
            }
        }
    }
}
