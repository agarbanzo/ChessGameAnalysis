using System;
using System.Collections.Generic;

namespace ChessGameAnalysis.Models
{
    public partial class Tournament
    {
        public Tournament()
        {
            Game = new HashSet<Game>();
        }

        public int Idtournament { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public ICollection<Game> Game { get; set; }
    }
}
