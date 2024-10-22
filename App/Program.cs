using App.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());

            value.IsOdd();
            value.IsEven();

            string str = "salam";
            str.ToCapitalize();
        }
    }
}
