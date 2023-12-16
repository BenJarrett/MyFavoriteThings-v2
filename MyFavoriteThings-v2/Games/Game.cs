using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings_v2.Games
{
    class Game
    {
        public string Title { get; set; }
        public string Dev { get; set; }
        public int Length { get; set; }



        public void Play()
        {
            Console.WriteLine($"I started playing {Title}. It's been a blast!");
        }
        
        public void Finished()
        {
            Console.WriteLine($"Finally! I finished it! Only took {Length} hours...");
        }

    }
}
