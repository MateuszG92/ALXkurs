using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alxkurs.Assigments.M2.L2
{
    public class Book
    {
        public string BookTitle;
        public string BookAuthor; 
        public string BookGenre;
        public string BookYear;
        public string BookPublishingHouse;

        public Book(string bookTitle, string bookAuthor, string bookGenre, string bookYear, string bookPublishingHouse)
        {
            BookTitle = bookTitle;
            BookAuthor = bookAuthor;
            BookGenre = bookGenre;
            BookYear = bookYear;
            BookPublishingHouse = bookPublishingHouse;
        }
    }
}
