using System;
using System.Collections.Generic;

namespace ChessGameAnalysis.Models
{
    public partial class GameStatistic
    {
        public int IdgameStatistic { get; set; }
        public int? ExcelentWhite { get; set; }
        public int? ExcelentBlack { get; set; }
        public int? GoodWhite { get; set; }
        public int? GoodBlack { get; set; }
        public int? LoosenessWhite { get; set; }
        public int? LoosenessBlack { get; set; }
        public int? ErrorWhite { get; set; }
        public int? ErrorBlack { get; set; }
        public int? BlunderWhite { get; set; }
        public int? BlunderBlack { get; set; }
        public int? ForcedWhite { get; set; }
        public int? ForcedBlack { get; set; }
        public float? BestMoveAverageWhite { get; set; }
        public float? BestMoveAvergageBlack { get; set; }
        public float? QualityDifferenceAverageWhite { get; set; }
        public float? QualityDifferenceAverageBlack { get; set; }

        public Game IdgameStatisticNavigation { get; set; }
    }
}
