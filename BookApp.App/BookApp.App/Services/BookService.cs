using BookApp.Core;

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
            string? v = Console.ReadLine();
            
                

            Array.Resize(ref Books, Books.Length + 1);

            Books[Books.Length - 1] = Newbook;
        }

    }
}