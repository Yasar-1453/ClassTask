using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> myList = new CustomList<string>();

            myList.Add("1");
            myList.Add("2");
            myList.Add("3");
            myList.Add("4");
            myList.Add("5");

            myList = myList.FindAllCustom(x => x == "6");

            foreach (var item in myList) 
            {

                Console.WriteLine(item);
            }



            List<string> yourList = new List<string>();

            yourList.Add("1");
            yourList.Add("2");
            yourList.Add("3");
            yourList.Add("4");
            yourList.Add("5");


           



        }
    }
}
