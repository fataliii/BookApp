namespace BookApp.Core
{
    public class Book
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public void CreateBook()
        {
            throw new NotImplementedException();
        }

        public void GetFullInfo()
        {
            Console.WriteLine(Name + " " + Price);
        }

        public void ShowBooks()
        {
            throw new NotImplementedException();
        }
    }
}