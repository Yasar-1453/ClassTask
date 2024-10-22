using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Helpers
{
    internal static class Helpers
    {
        static Helpers()
        {

        }

        public static void IsOdd(this int value)
        {
            if (value % 2 != 0)
            {
                Console.WriteLine("is odd");
            }


        }

        public static void IsEven(this int value)
        {
            if (value % 2 == 0)
            {
                Console.WriteLine("is even");
            }
        }

        public static void ToCapitalize(this string str)
        {


            Console.WriteLine(char.ToUpper(str[0]));

        }

        public static int[] GetValueIndex(this string str, char c)
        {
            int val = str.Length;

            int count = 0;

            for (int i = 0; i < val; i++)
            {
                if(str[i] == c)
                {
                    count++;
                }
            }

            int[] ints = new int[count];
            int ind = 0;

            for(int i = 0; i < val; i++)
            {
                if (str[i] == c)
                {
                    ints[ind++] = i;
                }
            }
            return ints;
        }

        public static bool CustomContain(this string str)
        {
            return str.IndexOf(str) != -1;
        }
    }
}
