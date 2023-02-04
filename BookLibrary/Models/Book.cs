using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public bool InStock { get; set; }
        public string Genre { get; set; }
    }
}
