using System;
using System.Collections.Generic;

namespace ChessGameAnalysis.Models
{
    public partial class Movement
    {
        public int NumberMovement { get; set; }
        public int Idgame { get; set; }
        public string MoveWhite { get; set; }
        public string MoveBlack { get; set; }
        public string FenWhite { get; set; }
        public string FenBlack { get; set; }
        public TimeSpan? TimeWhite { get; set; }
        public TimeSpan? TimeBlack { get; set; }

        public Game IdgameNavigation { get; set; }
    }
}
