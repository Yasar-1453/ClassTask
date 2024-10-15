using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp9
{
    internal class Program
    {
        //task
        class Car
        {
            string Brand;
            string Model;
            int CurrentFuel;
            int FuelFor1km;
            int Millage;

            public Car(int currentFuel, int millage)
            {
                this.CurrentFuel = currentFuel;
                this.Millage = millage;
            }

            public void Drive(int currentFuel, int millage)
            {
                int a = int.Parse(Console.ReadLine());
                for (int i = 0; i < a; i++)
                {
                    if (currentFuel > 0)
                    { 
                        millage += a;
                        currentFuel -= a;
                        
                    }
                    else
                    {
                        Console.WriteLine("kifayet qeder benzi yoxdu");
                        break;
                    }
                }

                Console.WriteLine($"{millage}, {currentFuel}");
            }

            //task 2

        }
            class Student
            {
                string Name;
                string Surname;
                string Group;
                int Point;
                bool isGraduated;

                public Student(string name, string surname, string group, int point)
                {
                    this.Name = name;
                    this.Surname = surname;
                    this.Group = group;
                    this.Point = point;
                    
                    if (point > 65)
                    {
                        isGraduated = true;
                    }
                }

                public void GetInfo(string name, string surname, string group, int point)
                {
                    Console.WriteLine($"{name}, {surname}, {group}, {point}");
                }

                public void CheckGraduation()
                {
                    if (isGraduated)
                    {
                        Console.WriteLine("telebe mezun olub");
                    }
                    else
                    {
                        Console.WriteLine("kesilib");
                    }
                    
                }

                public void GetDiplomDegree(int point)
                {
                    if( point < 65)
                    {
                        Console.WriteLine("kesilib");
                    }
                    else
                    {
                        Console.WriteLine("mezundur");
                    }
                }
            }

        static void Main(string[] args)
        {
            Car car = new Car(12, 100);

            car.Drive(12, 100);

            Student student = new Student("Ali", "Aliyev", "243A", 66);

            student.GetInfo("Ali", "Aliyev", "243A", 66);
            student.GetDiplomDegree(66);
            student.CheckGraduation();
            
        }
    }
}
