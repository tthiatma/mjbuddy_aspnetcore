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
    }
}
