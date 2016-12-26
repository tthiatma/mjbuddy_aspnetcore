using System.Collections.Generic;

namespace MjBuddy.Core.Entities.MjGame
{
    public class TileSet
    {
        public IEnumerable<TileGame> Tiles { get; set; }
        public TileSetType TileSetType { get; set; }
        public TileFigure TileType { get; set; }
        public bool isRevealed { get; set; }
    }
}
