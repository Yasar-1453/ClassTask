using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice_oct_25
{
    internal class Program
    {

        static void addHotel()
        {

            Console.WriteLine("Hotel adi daxil et");
            string hname = Console.ReadLine();

            Hotel hotel = new Hotel(hname);
        }



        static void Main(string[] args)
        {
            Room room = new Room("#03A", 15500, 300);
            Hotel hotel = new Hotel("Aliyev Hotel");


            bool f = false;





            do
            {
            APP_START:
                Console.WriteLine("Menu");
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "0":
                        f = true;
                        break;
                    case "1":
                        addHotel();
                        do
                        {
                            Console.WriteLine("new menu");
                            choose = Console.ReadLine();
                            switch (choose)
                            {
                                case "1":
                                    hotel.AddRoom(room);
                                    Console.WriteLine("otaq elave edildi");
                                    break;
                                case "2":
                                    Console.WriteLine(room.ShowInfo());
                                    break;
                                case "3":
                                    Console.Write("id elave et ");
                                    int id = int.Parse(Console.ReadLine());
                                    Console.Write("say elave et ");
                                    int count = int.Parse(Console.ReadLine());

                                    hotel.MakeReservation(id, count, room);
                                    Console.WriteLine("rezervasiya elave edildi");
                                    break;
                                case "4":
                                    goto APP_START;
                            }
                        }
                        while (!f);
                        break;

                    case "2":
                        hotel.ShowAllInfo();
                        break;
                    case "3":
                        f = true;
                        break;
                }
            }
            while (!f);
        }
    }
}
