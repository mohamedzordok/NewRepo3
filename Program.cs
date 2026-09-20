using System;

namespace BookAssignment
{
    enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }

    class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;
        public string Title;
        public Genre BookGenre;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            // question 1
            // book.password ==> can't access it here, it's private
            // if we try to print book.password it will give compile error
            // because private members can only be used inside the same class

            // question 2
            // internal fields can be accessed anywhere in the same project
            Console.WriteLine("copiesInStock = " + book.copiesInStock);

            // question 3
            book.Title = "Clean Code";
            Console.WriteLine("Title = " + book.Title);

            // question 4
            book.BookGenre = Genre.Science;
            Console.WriteLine("Genre = " + book.BookGenre);

            // question 5
            // casting enum to int to get the underlying number
            int fictionNum = (int)Genre.Fiction;
            int nonFictionNum = (int)Genre.NonFiction;
            int scienceNum = (int)Genre.Science;
            Console.WriteLine("Fiction = " + fictionNum);
            Console.WriteLine("NonFiction = " + nonFictionNum);
            Console.WriteLine("Science = " + scienceNum);

            // question 6
            int genreNumber = 1;
            Genre g1 = (Genre)genreNumber;
            Console.WriteLine("genre from number = " + g1);

            // question 7
            Genre g2 = Genre.Fiction;
            string genreStr = g2.ToString();
            Console.WriteLine("genre as string = " + genreStr);

            // question 8
            string genreText = "Science";
            Genre g3 = (Genre)Enum.Parse(typeof(Genre), genreText);
            Console.WriteLine("parsed genre = " + g3);

            // question 9
            string genreText2 = "Mystery";
            Genre g4;
            bool ok = Enum.TryParse(genreText2, out g4);

            if (ok)
            {
                Console.WriteLine("genre = " + g4);
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }

            Console.ReadLine();
        }
    }
}
