using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_indi
{
    internal class Library
    {
        public string Name;
        Book[] Books = new Book[0];

        public void AddBook(Book book)
        {
            Book[] newBook = new Book[Books.Length + 1];

            for (int i = 0; i < Books.Length; i++)
            {
                newBook[i] = Books[i];
            }
            newBook[Books.Length] = book;
            Books = newBook;
        }

        public void ShowBook()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine(book.Name + " " + book.Price );
            }
        }

        public void SearchBook(string name)
        {
            foreach (Book book in Books)
            {
                if (book.Name == name)
                {
                    Console.WriteLine($"{name} tapildi");
                }
                else
                {
                    Console.WriteLine($"{name} tapilmadi");
                }
            }
        }
    }
}
