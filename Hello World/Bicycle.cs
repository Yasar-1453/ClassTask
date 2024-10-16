using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Bicycle : Vehicle
    {
        private int _wheelNum;

        public Bicycle(string brand, string model, int mile, int wheelNum) : base(brand, model, mile)
        {
            _wheelNum = wheelNum;
        }

        
        public int DoorNum
        {
            get
            {
                return _wheelNum;
            }
            set
            {
                if (value > 0 && value < 5)
                {
                    Console.WriteLine(_wheelNum);
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
        }

        public void ShowFullInfo(string brand, string model, int mile, int wheelNum)
        {
            Console.WriteLine($"Brand: {brand}, Model: {model}, Mile: {mile}, Wheel Number: {wheelNum}");
        }
    }
}
