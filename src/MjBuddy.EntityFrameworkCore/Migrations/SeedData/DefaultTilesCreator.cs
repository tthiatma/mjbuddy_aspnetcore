using MjBuddy.Core.Entities.MjGame;
using System.Linq;

namespace MjBuddy.EntityFrameworkCore.Migrations.SeedData
{
    public class DefaultTilesCreator
    {
        private MjBuddyDbContext _context;

        public DefaultTilesCreator(MjBuddyDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateTiles();
        }

        private void CreateTiles()
        {
            var tile = _context.Tiles.FirstOrDefault(t => t.Name == "");
            if (tile == null)
            {
                tile = new Tile { Name = "", Image = "", ImageSmall= "", Type = TileFigure.Money, Value = TileValue.One };
                _context.Tiles.Add(tile);
                _context.SaveChanges();
            }
            _context.SaveChanges();
        }
    }
}
