namespace DataStructureHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Book book1 = new Book("Qerb burkusu", "Cingiz Abdullayev", 300,2013);
            Book book2 = new Book("Sefiller", "Viktor Huqo", 1174, 1862);
            Book book3 = new Book("Cinayet ve Ceza", "Dostoyevski", 845, 1866);
            Book[] books = new Book[] { book1, book2, book3 };
            foreach (Book book in books)
            {
                Console.WriteLine($"{book}\n---");
            }

            #endregion
            #region Task 2
            book1.ReturnFullInfo();
            #endregion







        }
    }
}