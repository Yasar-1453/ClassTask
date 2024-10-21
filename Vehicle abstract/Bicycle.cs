using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_abstract
{
    internal class Bicycle : Vehicle
    {
        public int WheelCount { get; }

        public Bicycle(string factoryName, string model, string color, double driveTime, int drivePath, int wheelCount) : base(factoryName, model, color, driveTime, drivePath)
        {
            WheelCount = wheelCount;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Wheel Count: {WheelCount}";
        }

        public override string DefineNatureHarmess()
        {
            return "none";
        }

    }
}
