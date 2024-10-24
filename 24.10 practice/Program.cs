using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._10_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person = new Person()
                {
                    FullName = "yasar",
                    Age = 126
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
