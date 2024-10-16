using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Vehicle
    {
        private string _brand;
        private string _model;
        private double _mile;

        public Vehicle(string brand, string model, double mile)
        {
            _brand = brand;
            _model = model;
            _mile = mile;
        }

        public string Brand
        {
            get
            {
                return _brand;
            }

            set
            {
                if (_brand.Length > 3 && _brand.Length < 30)
                {
                    Console.WriteLine(_brand);
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
        }

        public string Model 
        {
            get
            {
                return _model;
            }
            set
            {
                if (_model.Length > 3 && _model.Length < 30)
                {
                    Console.WriteLine(_model);
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
        }

        public double Mile
        {
            get
            {
                return _mile;
            }
            set
            {
                if(value > 0)
                {
                    Console.WriteLine(_mile);
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
        }
    }
}
