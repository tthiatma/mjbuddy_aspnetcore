using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MjBuddy.Core.Entities.Account;
using MjBuddy.Core.Entities.MjGame;

namespace MjBuddy.EntityFrameworkCore
{
    public class MjBuddyDbContext : IdentityDbContext<ApplicationUser>
    {
        public MjBuddyDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Tile> Tiles { get; set; }
        public DbSet<TileGame> TileGames { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameRecord> GameRecords { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<GameSetting> GameSettings { get; set; }
        public DbSet<Player> Players { get; set; }
        
    }
}
