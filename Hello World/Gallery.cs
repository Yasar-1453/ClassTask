using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hello_World
{
    internal class Gallery
    {
        Car[] Car = new Car[0];

        public void AddCar(Car car)
        {
            Car[] newCaR = new Car[Car.Length + 1];

            for (int i = 0; i < Car.Length; i++)
            {
                newCaR[i] = Car[i];
            }
            newCaR[newCaR.Length - 1] = car;
            Car = newCaR;
        }

        public Car FilterCar(int mile)
        {
            foreach (Car cars in Car)
            {
                if(cars.Mile == mile)
                {
                    Console.WriteLine("tapildi");
                    return cars;
                }
                else
                {
                    Console.WriteLine("tapilmadi");
                    return null;
                }
            }
            return null;
        }

        public Car FilterCar(string brand,  int mile)
        {
            foreach(Car cars in Car)
            {
                if(cars.Brand == brand)
                {
                    Console.WriteLine("tapildi");
                    return cars;
                }
                else
                {
                    Console.WriteLine("tapilmadi");
                    return null;
                }
            }
            return null;
        }
    }
}
