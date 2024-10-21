using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_abstract
{
    internal class Car : Vehicle
    {
        public int DoorCount { get; }
        public bool IsElectricCar { get; }

        public Car(string factoryName, string model, string color, double driveTime, int drivePath, int doorCount, bool isElectricCar)
        : base(factoryName, model, color, driveTime, drivePath)
        {
            DoorCount = doorCount;
            IsElectricCar = isElectricCar;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Door Count: {DoorCount}, Is Electric Car: {IsElectricCar}";
        }

        public override string DefineNatureHarmess()
        {
            if (IsElectricCar == true)
            {
                return "high";
            }
            else
            {
                return "low";
            }
        }


    }
}
