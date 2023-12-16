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

        int _readPage;

        public void Open()
        {
            Console.WriteLine($"I sat down and opened up {Title} by {Author}");
        }

        
        public void Read()
        {
            {
                _readPage++;
                Console.WriteLine($"I read another page! That's {_readPage} so far.");
            }
            
        }


    }

    
}
