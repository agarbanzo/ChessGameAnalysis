using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ChessGameAnalysis.Models
{
    public partial class chessgameanalyticsContext : DbContext
    {
        public virtual DbSet<FinalizationType> FinalizationType { get; set; }
        public virtual DbSet<Game> Game { get; set; }
        public virtual DbSet<GameStatistic> GameStatistic { get; set; }
        public virtual DbSet<Movement> Movement { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Tournament> Tournament { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=password;database=chessgameanalytics");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FinalizationType>(entity =>
            {
                entity.HasKey(e => e.IdfinalizationType);

                entity.ToTable("finalization_type");

                entity.Property(e => e.IdfinalizationType)
                    .HasColumnName("idfinalization_type")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(75);
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.HasKey(e => e.Idgame);

                entity.ToTable("game");

                entity.HasIndex(e => e.IdfinalizationType)
                    .HasName("fk_idfinalization_idx");

                entity.HasIndex(e => e.IdplayerBlack)
                    .HasName("fk_playerblack_idx");

                entity.HasIndex(e => e.IdplayerWhite)
                    .HasName("fk_playerwhite_idx");

                entity.HasIndex(e => e.Idtournament)
                    .HasName("fk_idtournament_idx");

                entity.Property(e => e.Idgame)
                    .HasColumnName("idgame")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EloPlayerBlack)
                    .HasColumnName("elo_player_black")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EloPlayerWhite)
                    .HasColumnName("elo_player_white")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FinalPositionFen)
                    .HasColumnName("final_position_FEN")
                    .HasMaxLength(150);

                entity.Property(e => e.IdfinalizationType)
                    .HasColumnName("idfinalization_type")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdplayerBlack)
                    .HasColumnName("idplayer_black")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdplayerWhite)
                    .HasColumnName("idplayer_white")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idtournament)
                    .HasColumnName("idtournament")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasMaxLength(7);

                entity.Property(e => e.Site)
                    .HasColumnName("site")
                    .HasMaxLength(100);

                entity.Property(e => e.TimeControl)
                    .HasColumnName("time_control")
                    .HasMaxLength(45);

                entity.HasOne(d => d.IdfinalizationTypeNavigation)
                    .WithMany(p => p.Game)
                    .HasForeignKey(d => d.IdfinalizationType)
                    .HasConstraintName("fk_idfinalization");

                entity.HasOne(d => d.IdplayerBlackNavigation)
                    .WithMany(p => p.GameIdplayerBlackNavigation)
                    .HasForeignKey(d => d.IdplayerBlack)
                    .HasConstraintName("fk_playerblack");

                entity.HasOne(d => d.IdplayerWhiteNavigation)
                    .WithMany(p => p.GameIdplayerWhiteNavigation)
                    .HasForeignKey(d => d.IdplayerWhite)
                    .HasConstraintName("fk_playerwhite");

                entity.HasOne(d => d.IdtournamentNavigation)
                    .WithMany(p => p.Game)
                    .HasForeignKey(d => d.Idtournament)
                    .HasConstraintName("fk_idtournament");
            });

            modelBuilder.Entity<GameStatistic>(entity =>
            {
                entity.HasKey(e => e.IdgameStatistic);

                entity.ToTable("game_statistic");

                entity.HasIndex(e => e.IdgameStatistic)
                    .HasName("idgame_statistic_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdgameStatistic)
                    .HasColumnName("idgame_statistic")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BestMoveAverageWhite).HasColumnName("best_move_average_white");

                entity.Property(e => e.BestMoveAvergageBlack).HasColumnName("best_move_avergage_black");

                entity.Property(e => e.BlunderBlack)
                    .HasColumnName("blunder_black")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BlunderWhite)
                    .HasColumnName("blunder_white")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ErrorBlack)
                    .HasColumnName("error_black")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ErrorWhite)
                    .HasColumnName("error_white")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExcelentBlack)
                    .HasColumnName("excelent_black")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExcelentWhite)
                    .HasColumnName("excelent_white")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ForcedBlack)
                    .HasColumnName("forced_black")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ForcedWhite)
                    .HasColumnName("forced_white")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GoodBlack)
                    .HasColumnName("good_black")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GoodWhite)
                    .HasColumnName("good_white")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LoosenessBlack)
                    .HasColumnName("looseness_black")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LoosenessWhite)
                    .HasColumnName("looseness_white")
                    .HasColumnType("int(11)");

                entity.Property(e => e.QualityDifferenceAverageBlack).HasColumnName("quality_difference_average_black");

                entity.Property(e => e.QualityDifferenceAverageWhite).HasColumnName("quality_difference_average_white");

                entity.HasOne(d => d.IdgameStatisticNavigation)
                    .WithOne(p => p.GameStatistic)
                    .HasForeignKey<GameStatistic>(d => d.IdgameStatistic)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_game_statistic");
            });

            modelBuilder.Entity<Movement>(entity =>
            {
                entity.HasKey(e => new { e.NumberMovement, e.Idgame });

                entity.ToTable("movement");

                entity.HasIndex(e => e.Idgame)
                    .HasName("fk_game_idx");

                entity.Property(e => e.NumberMovement)
                    .HasColumnName("number_movement")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idgame)
                    .HasColumnName("idgame")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FenBlack)
                    .HasColumnName("fen_black")
                    .HasMaxLength(150);

                entity.Property(e => e.FenWhite)
                    .HasColumnName("fen_white")
                    .HasMaxLength(150);

                entity.Property(e => e.MoveBlack)
                    .HasColumnName("move_black")
                    .HasMaxLength(15);

                entity.Property(e => e.MoveWhite)
                    .IsRequired()
                    .HasColumnName("move_white")
                    .HasMaxLength(15);

                entity.Property(e => e.TimeBlack)
                    .HasColumnName("time_black")
                    .HasColumnType("time");

                entity.Property(e => e.TimeWhite)
                    .HasColumnName("time_white")
                    .HasColumnType("time");

                entity.HasOne(d => d.IdgameNavigation)
                    .WithMany(p => p.Movement)
                    .HasForeignKey(d => d.Idgame)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_game");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasKey(e => e.Idplayer);

                entity.ToTable("player");

                entity.HasIndex(e => e.Name)
                    .HasName("IDX_NAME");

                entity.Property(e => e.Idplayer)
                    .HasColumnName("idplayer")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Tournament>(entity =>
            {
                entity.HasKey(e => e.Idtournament);

                entity.ToTable("tournament");

                entity.Property(e => e.Idtournament)
                    .HasColumnName("idtournament")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(45);

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("datetime");
            });
        }
    }
}
