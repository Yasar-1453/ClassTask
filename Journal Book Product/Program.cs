using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal_Book_Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddProduct(new Book("C# Programming", 29.69, "John Doe", "Programming"));
            library.AddProduct(new Journal("Tech Monthly", 5.99, "Tech Corp"));

            Console.Write("Min Price: ");
            double minPrice = double.Parse(Console.ReadLine());

            Console.Write("Max Price: ");
            double maxPrice = double.Parse(Console.ReadLine());

            var productsByPrice = library.GetProductByPrice(minPrice, maxPrice);
            Console.WriteLine("Products in price range:");
            foreach (var product in productsByPrice)
            {
                Console.WriteLine(product.GetInfo());
            }

            // Adı üçün dəyəri qəbul edin
            Console.Write("Enter product name to search: ");
            string name = Console.ReadLine();

          
            var productsByName = library.GetProductsByName(name);
            Console.WriteLine("Products with name containing '{0}':", name);
            foreach (var product in productsByName)
            {
                Console.WriteLine(product.GetInfo());
            }



        }
    }
}
