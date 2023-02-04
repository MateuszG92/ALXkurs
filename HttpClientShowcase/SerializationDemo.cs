using HttpClientShowcase.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientShowcase
{
    public class SerializationDemo
    {
        public BookJsonSamples RunSerialization()
        {
            var book = new Book
            {
                Id = 1,
                Title = "The Hogfather",
                Author = "Retty Prachett",
                Genre = "Fantasy"
            };

            var book2 = new Book
            {
                Id = 2,
                Title = "The Godfather",
                Author = "Mario Puzo",
                Genre = "Drama"
            };

            var bookJson = JsonConvert.SerializeObject(book);

            var bookBox = new BookBox
            {
                Id = 120,
                Book = book
            };

            var bookBoxJson = JsonConvert.SerializeObject(bookBox);

            var shelf = new List<Book>();
            shelf.Add(book);
            shelf.Add(book2);

            var bookShelf = new BookShelf
            {
                Id = 3,
                Books = shelf
            };

            var bookShelfJson = JsonConvert.SerializeObject(bookShelf);

            Console.WriteLine(bookJson);
            Console.WriteLine(bookBoxJson);
            Console.WriteLine(bookShelfJson);

            return new BookJsonSamples
            {
                BookJson = bookJson,
                BookBoxJson = bookBoxJson,
                BookShelfJson = bookShelfJson
            };
        }

        public void RunDeserialization(BookJsonSamples jsonStrings)
        {
            var book=JsonConvert.DeserializeObject<Book>(jsonStrings.BookJson);
            var bookBox=JsonConvert.DeserializeObject<BookBox>(jsonStrings.BookBoxJson);
            var bookShelf = JsonConvert.DeserializeObject<BookShelf>(jsonStrings.BookShelfJson);
        }
    }
}
