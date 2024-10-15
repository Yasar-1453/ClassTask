using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_indi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library kitabKhana = new Library()
            {
                Name = "Balacayev",
            };
            Library kitabKhana2 = new Library()
            {
                Name = "test",
            };
            Library kitabKhana3 = new Library()
            {
                Name = "test3",
            };


            Book bok = new Book("ElxanElatli" , 9.99);
            Book bok2 = new Book("Kitabxana", 10);
            Book bok3 = new Book("CodeAcademy", 10.01);


            kitabKhana.AddBook(bok);
            kitabKhana2.AddBook(bok2);
            kitabKhana3.AddBook(bok3);


            kitabKhana.ShowBook();
            kitabKhana2.ShowBook();
            kitabKhana3.ShowBook();

            kitabKhana2.SearchBook("Kitabxana");
            kitabKhana2.SearchBook("test");


        }
    }
}
