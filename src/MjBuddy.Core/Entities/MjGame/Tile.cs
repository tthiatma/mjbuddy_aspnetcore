using System.ComponentModel.DataAnnotations.Schema;

namespace MjBuddy.Core.Entities.MjGame
{
    [Table("AppTiles")]
    public class Tile
    {
        public int Id { get; set; }
        public TileType Type { get; set; }
        public TileValue Value { get; set; }
        public string Image { get; set; }
        public string ImageSmall { get; set; }
        public string Name { get; set; }
    }
}
