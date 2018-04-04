using System;
using System.Collections.Generic;

namespace ChessGameAnalysis.Models
{
    public partial class Game
    {
        public Game()
        {
            Movement = new HashSet<Movement>();
        }

        public int Idgame { get; set; }
        public int? Idtournament { get; set; }
        public string Site { get; set; }
        public DateTime? Date { get; set; }
        public int? IdplayerWhite { get; set; }
        public int? IdplayerBlack { get; set; }
        public int? EloPlayerWhite { get; set; }
        public int? EloPlayerBlack { get; set; }
        public string TimeControl { get; set; }
        public int? IdfinalizationType { get; set; }
        public string Result { get; set; }
        public string FinalPositionFen { get; set; }

        public FinalizationType IdfinalizationTypeNavigation { get; set; }
        public Player IdplayerBlackNavigation { get; set; }
        public Player IdplayerWhiteNavigation { get; set; }
        public Tournament IdtournamentNavigation { get; set; }
        public GameStatistic GameStatistic { get; set; }
        public ICollection<Movement> Movement { get; set; }
    }
}
