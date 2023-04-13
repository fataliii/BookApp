
using BookApp.Core;
Book book = new Book();

Console.WriteLine("0.Close App");
Console.WriteLine("1.Show Books");
Console.WriteLine("2.Create Book");

string RequestNumber = Console.ReadLine();

while (RequestNumber != "0")
{
    switch (RequestNumber)
    {
        case "1":
            book.ShowBooks();
            break;
        case "2":
            book.CreateBook();
            break;

        default:
            Console.WriteLine("Select valid option");
            break;
    }

    Console.WriteLine("0.Close App");
    Console.WriteLine("1.Show Books");
    Console.WriteLine("2.Create Book");

    RequestNumber = Console.ReadLine();
}
