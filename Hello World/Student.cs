using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Student
    {
        public string Name;
        public string Surname;
        Grade[] Grade = new Grade[0];

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void AddGrade(Grade grade)
        {
            Grade[] newGrade = new Grade[Grade.Length + 1];

            for (int i = 0; i < Grade.Length; i++)
            {
                newGrade[i] = Grade[i];
            }
            newGrade[Grade.Length] = grade;
            Grade = newGrade;
        }

        public double GetAvgGrade()
        {
            double s = 0;
            double t = 0;
            
            foreach (Grade grade in Grade)
            {
                s += grade.Point;
                t = s / Grade.Length;
            }
            return t;
        }

        public int GetCreditCount()
        {
            int totalCredits = 0;

            foreach(Grade grade in Grade)
            {
                totalCredits += grade.CreditCount;
            }
            return totalCredits;
        }
    }
}
