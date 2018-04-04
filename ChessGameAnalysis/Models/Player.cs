using System;
using System.Collections.Generic;

namespace ChessGameAnalysis.Models
{
    public partial class Player
    {
        public Player()
        {
            GameIdplayerBlackNavigation = new HashSet<Game>();
            GameIdplayerWhiteNavigation = new HashSet<Game>();
        }

        public int Idplayer { get; set; }
        public string Name { get; set; }

        public ICollection<Game> GameIdplayerBlackNavigation { get; set; }
        public ICollection<Game> GameIdplayerWhiteNavigation { get; set; }
    }
}
