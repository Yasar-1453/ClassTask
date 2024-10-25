using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_oct_25
{
    internal class Hotel
    {
        private int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        private int _currentHotelCount = 0;

        Room[] Rooms = new Room[0];

        public Hotel(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NotAvailableException("otaq yoxdu");
            }
            Id = ++_id;
            Name = name;

        }

        public void AddRoom(Room room)
        {
            Array.Resize(ref Rooms, Rooms.Length + 1);
            Rooms[Rooms.Length - 1] = room;
        }

        public Room[] FindAllRoom()
        {
            Room[] rooms = new Room[0];
            foreach (Room room in Rooms)
            {
                Array.Resize(ref rooms, rooms.Length);
                rooms[Rooms.Length - 1] = room;
                Console.WriteLine($"Name {room.Name}");
            }
            return rooms;
        }

        public void MakeReservation(int? roomId, int count, Room room)
        {
            bool IsAvaiable = true;
            
            if (roomId == null)
            {
                throw new NullReferenceException("id tapilmdadi");
            }
            if (!IsAvaiable)
            {
                throw new NotAvailableException("unAvaiable");
            }
            if(count > room.PersonCapacity)
            {
                throw new ArgumentException("yer dolub");
            }
        }

        public void ShowAllInfo()
        {
            foreach(Room room in Rooms)
            {
                Console.WriteLine($"Name {Name} id {Id}");
            }
        }
    }
}
