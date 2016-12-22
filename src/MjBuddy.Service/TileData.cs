using System.Linq;
using MjBuddy.EntityFrameworkCore;
using MjBuddy.Core.Entities.MjGame;

namespace MjBuddy.Service
{
    public class TileData : ITileData
    {
        private MjBuddyDbContext _context;

        public Tile Get(int id)
        {
            return _context.Tiles.FirstOrDefault(t => t.Id == id);
        }

        public TileData(MjBuddyDbContext context)
        {
            _context = context;
        }
    }
}
