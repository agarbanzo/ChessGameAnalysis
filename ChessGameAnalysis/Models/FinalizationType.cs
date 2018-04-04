using System;
using System.Collections.Generic;

namespace ChessGameAnalysis.Models
{
    public partial class FinalizationType
    {
        public FinalizationType()
        {
            Game = new HashSet<Game>();
        }

        public int IdfinalizationType { get; set; }
        public string Description { get; set; }

        public ICollection<Game> Game { get; set; }
    }
}
