using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings_v2.Books
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Length { get; set; }


        public Book(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
        }

        int _numberOfPagesRead;
        public void Open()
        {
            Console.WriteLine($"I sat down and opened up {Title} by {Author}");
        }

        public void Read(int pagesRead)
        {
            _numberOfPagesRead++;
            Console.WriteLine($"I've read {pagesRead} pages so far." );
        }

    }

    
}
