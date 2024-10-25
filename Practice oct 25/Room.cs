using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_oct_25
{
    internal class Room
    {

        private int _id;
        public int Id { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsActive { get; set; } = true;

        public Room(string name, double price, int personCapacity)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }
        

        public override string ToString()
        {
            return ShowInfo();
        }

        public string ShowInfo()
        {
            return $"Name: {Name}, Price: {Price}, Person Capacity: {PersonCapacity}";
        }
    }
}
