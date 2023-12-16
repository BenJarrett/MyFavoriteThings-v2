using MyFavoriteThings_v2.Books;
using MyFavoriteThings_v2.Games;
using System;

namespace MyFavoriteThings_v2
{
    class Program
    {


        static void Main(string[] args)
        {

            var cyberpunk = new Game
            {
                Title = "CyberPunk",
                Dev = "CD Project Red",
                Length = 75
            };

            var witcher = new Game
            {
                Title = "The Wticher",
                Dev = "CD Project Red",
                Length = 150
            };

            cyberpunk.Play();
            cyberpunk.Finished();

            var gOT = new Book("Game Of Thones", "George R.R. Martin", 867);


            gOT.Read();
            gOT.Read();
            gOT.Read();
            gOT.Read();
            gOT.Read();

            

        }
        
    }
}

