using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Grade
    {
        public string Subject;
        public int Point;
        public int CreditCount;

        public Grade(string subject, int point, int creditCount)
        {
            Subject = subject;
            Point = point;
            CreditCount = creditCount;
        }
    }
}
