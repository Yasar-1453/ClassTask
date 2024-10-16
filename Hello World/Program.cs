using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Yasar", "Sukurov");

            Grade grade = new Grade("Math", 87, 8);
            Grade grade2 = new Grade("History", 54, 4);
            Grade grade3 = new Grade("English", 91, 6);

            student.AddGrade(grade);
            student.AddGrade(grade2);
            student.AddGrade(grade3);

            Console.WriteLine(student.GetAvgGrade());
            Console.WriteLine(student.GetCreditCount());

            Bicycle bicycle = new Bicycle("Kawasaki", "H2R Ninja", 340, 2);

            bicycle.ShowFullInfo("Kawasaki", "H2R Ninja", 340, 2);

            Gallery gallery = new Gallery();

            Car car = new Car("Mercedes", "E-230", 300, 4);

            gallery.AddCar(car);

            gallery.FilterCar(300);
            gallery.FilterCar("Mercedes",300);

            car.ShowFullInfo("Mercedes", "E-230", 300, 4);



        }
    }
}
