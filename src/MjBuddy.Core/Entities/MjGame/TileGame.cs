using System.ComponentModel.DataAnnotations.Schema;

namespace MjBuddy.Core.Entities.MjGame
{
    /// <summary>
    /// Represents tiles in game showing who has the tile and the tile status
    /// </summary>
    /// 
    [Table("AppTileGames")]
    public class TileGame
    {
        public long Id { get; set; }
       
        public Tile Tile { get; set; }

        public TileHolder TileStatus { get; set; }

        //this is to show which user id own the tile
        public string Owner { get; set; }
        
        //this is the counter to sort tile on board graveyard
        public int GraveYardCounter { get; set; }

        //this is the counter to sort tile on user active hand
        public int UserHandCounter { get; set; }
    }
}
