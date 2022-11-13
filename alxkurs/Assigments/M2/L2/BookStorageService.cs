using alxkurs.Assigments.M2.L1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using alxkurs.Assigments.M2.L2;
using alxkurs.Lessons.M2.L1.ClassesAndEnums;

namespace alxkurs.Assigments.M2.L2
{
    public class BookStorageService
    {
        public string Title;
        public string Author;
        public string Genre;
        public int Year;
        public string PublishingHouse;
        public List<Book> HorrorBooks;
        public List<Book> RomanceBooks;
        public List<Book> SciFiBooks;
        public BookStorageService()
        {
            HorrorBooks = new List<Book>();
            RomanceBooks = new List<Book>();
            SciFiBooks = new List<Book>();
        }

        public static void CreateBook()
        {
            var bookStorageService = new BookStorageService();
            Console.WriteLine("Add new book (Y/N):");
            var wantToCreateBook = Console.ReadLine().ToLower();
            while (wantToCreateBook == "y")
            {
                Console.WriteLine("Enter book title:");
                var title = Console.ReadLine();
                Console.WriteLine("Enter book author:");
                var author = Console.ReadLine();
                Console.WriteLine("Enter book genre (horror,romance,scifi:");
                var genre = Console.ReadLine().ToLower().Replace("-","");
                Console.WriteLine("Enter book year:");
                var year = Console.ReadLine();
                Console.WriteLine("Enter book publisher:");
                var publisher = Console.ReadLine();
                var book = new Book(title, author, genre, year, publisher);
                bookStorageService.ClassifyBook(book);
                Console.WriteLine("Add new book (Y/N):");
                wantToCreateBook = Console.ReadLine().ToLower();
            }
            if (wantToCreateBook == "n")
            {
                Console.WriteLine("Do you want to see classified book list? (Y/N):");
                var wantToSeeList = Console.ReadLine().ToLower();
                if (wantToSeeList == "y")
                {
                    Console.WriteLine("Horror books:");
                    PresentBooks(bookStorageService.HorrorBooks);                    
                    Console.WriteLine("Romance books:");
                    PresentBooks(bookStorageService.RomanceBooks);
                    Console.WriteLine("SciFi books:");
                    PresentBooks(bookStorageService.SciFiBooks);
                }
            }
            else
            {
                Console.WriteLine("End");
            }
        }

        public void ClassifyBook(Book book)
        {
           if (book.BookGenre == "horror")
                {
                    HorrorBooks.Add(book);
                }
           else if (book.BookGenre == "romance")
                {
                    RomanceBooks.Add(book);
                }
           else if (book.BookGenre=="scifi")
                {
                    SciFiBooks.Add(book);
                }
        }

        public static void PresentBooks(List<Book> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"\tTitle: {book.BookTitle}");
                Console.WriteLine($"\tAuthor: {book.BookAuthor}");
                Console.WriteLine($"\tYear: {book.BookYear}");
                Console.WriteLine($"\tPublisher: {book.BookPublishingHouse}");
            }           
        }
    }
}
