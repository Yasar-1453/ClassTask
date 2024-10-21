using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_abstract
{
    internal abstract class Vehicle
    {
        public string FactoryName { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double DriveTime { get; set; }
        public int DrivePath { get; set; }

        public DateTime ProductionDate { get; set; }

        public Vehicle(string factoryName, string model, string color, double driveTime, int drivePath)
        {
            FactoryName = factoryName;
            Model = model;
            Color = color;
            ProductionDate = DateTime.UtcNow ;
            DrivePath = drivePath;
            DriveTime = driveTime;
        }

        public double AverageSpeed()
        {
            double avg = DrivePath / DriveTime;
            return avg;
        }

        public virtual string GetInfo()
        {
            return $"{FactoryName}, {Model}, {Color}, {DrivePath}, {DriveTime}, {ProductionDate}";
        }

        public override string ToString()
        {
            return $"{FactoryName}, {Model}";
        }

        public abstract string DefineNatureHarmess();
    }
}
