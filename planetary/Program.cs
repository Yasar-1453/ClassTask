using planetary.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using planetary.core.Enums;

namespace planetary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Planet planet = new Planet("Dunya");
            Country country = new Country("asas", "sdsada", "sup", Region.Australia);

            AppDbContext db = new AppDbContext();

            bool f = false;

            

            do
            {
                Console.WriteLine("***Menu***\r\n\r\n1.Sisteme giris\r\n0.Cixis");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        do
                        {
                            MENU1:
                            Console.WriteLine("1.planet yarat \r\n2.Butun Planetleri gor\r\n3.Planet sec (planetin adini daxil ederek secilecek)\r\n0.Exit");
                            choice = Console.ReadLine();
                            switch (choice)
                            {
                                case "0":
                                    f = true;
                                    break;
                                case "1":
                                    db.CreatPlanet(planet);
                                    Console.WriteLine("planet elave edildi");
                                    break;

                                case "2":
                                    List<Planet> list = db.GetAllPlanets();
                                    foreach (var item in list)
                                    {
                                        Console.WriteLine($"Planet Name: {item.PlanetName}");
                                    }
                                    break;
                                case "3":
                                    if (planet != null)
                                    {
                                        do
                                        {
                                            Console.WriteLine("1.olke yarat\r\n2.olke gor\r\n3.Evvelki menuya qayit.\r\n0.Exit");
                                            Console.WriteLine("new menu");
                                            string choose = Console.ReadLine();
                                            switch (choose)
                                            {
                                                case "1":
                                                    db.CreatCountry(country);
                                                    Console.WriteLine("olke elave edildi");
                                                    break;
                                                case "2":
                                                    List<Country> list1 = db.GetAllCountries();
                                                    foreach (var item in list1)
                                                    {
                                                        Console.WriteLine($"Country: {item.CountryName}, Area: {item.Area}, Anthem: {item.Anthem}, Region: {item.Region}");
                                                    }
                                                    break;
                                                case"3":
                                                    goto MENU1;
                                                case "0":
                                                    f = true;
                                                    break;
                                            }
                                        }
                                        while (!f);
                                    }
                                    break;
                            }

                        
                        } while (!f) ;
                break;
                case "0":
                    f = true;
                        break ;
            }

            } while (!f);
        }
}
}
