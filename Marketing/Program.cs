using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Product product = new Product("Bonaqua", 29.99, Type.Drink);

            bool f = false;

            Console.WriteLine("1. Add Product  2. Filter Products by Type  3 Remove product 4 Get product 5. Exit");
            do
            {
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        try
                        {
                            store.AddProduct(product);
                            Console.WriteLine("Product added successfully.");
                        }
                        catch (PriceMustBeGratherThanZeroExpection ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        break;
                    case "2":
                        Console.WriteLine("Filtered Products:");
                        store.FilterProductsByType(Type.Drink);
                        break;
                    case "3":
                        store.RemoveProduct(1);
                        break;
                    

                    case "5":
                        f = true;
                        break;
                }
            }
            while (!f);
        }
    }
}
