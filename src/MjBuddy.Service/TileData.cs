using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MjBuddy.Core.Entities;
using MjBuddy.EntityFrameworkCore;

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
