using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.App.Services
{
    public class BookService
    {
        private Book[] Books = new Book[0];

        public void ShowBooks()
        {
            if (Books.Length == 0)
            {
                Console.WriteLine("Not available Books");
            }

            foreach (Book book in Books)
            {
                book.GetFullInfo();
            }
        }

        public void CreateBook()
        {

            Book Newbook = new Book();

            Console.WriteLine("add Name");
            Newbook.Name = Console.ReadLine();
            Console.WriteLine("add Price");
            Newbook.Email = Console.ReadLine();

            Array.Resize(ref Books, Books.Length + 1);

            Books[Books.Length - 1] = Newbook;
        }

    }
}