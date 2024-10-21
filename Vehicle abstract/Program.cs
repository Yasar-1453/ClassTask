using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[]
       {
            new Car("Toyota", "Corolla", "Red", 1, 120, 4, false),
            new Car("Tesla", "Model 3", "Blue", 1, 150, 4, true),
            new Bicycle("Giant", "Escape 3", "Black", 2, 30, 2),
            new Bicycle("Trek", "Domane AL", "Green", 3, 40, 2)
       };

            foreach (var vehicle in vehicles)
            {
                vehicle.GetInfo();
                Console.WriteLine($"Average Speed: {vehicle.AverageSpeed()} km/h");
               Console.WriteLine($"Nature Harmness: {vehicle.DefineNatureHarmess()}");
                Console.WriteLine(vehicle.ToString());
                Console.WriteLine();
            }
        }
    }
}
