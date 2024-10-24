using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing
{
    internal class PriceMustBeGratherThanZeroExpection : Exception
    {
        public PriceMustBeGratherThanZeroExpection(string mesage) : base(mesage)
        {

        }
    }
}
