using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Car : Vehicle
    {
        private int _doorNum;

        public Car(string brand, string model, int mile, int doorNum) : base(brand, model, mile)
        {
            _doorNum = doorNum;
        }

        public int DoorNum
        {
            get
            {
                return _doorNum;
            }
            set
            {
                if (value > 0 && value < 5)
                {
                    Console.WriteLine(_doorNum);
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
        }

        public void ShowFullInfo(string brand, string model, int mile, int doorNum)
        {
            Console.WriteLine($"Brand: {brand}, Model: {model}, Mile: {mile}, Door Number: {doorNum}");
        }
    }
}
