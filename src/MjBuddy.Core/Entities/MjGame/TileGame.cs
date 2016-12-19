namespace MjBuddy.Core.Entities.MjGame
{
    public class TileGame
    {
        public int Id { get; set; }
       
        public Tile Tile { get; set; }

        public TileStatus TileStatus { get; set; }

        //this is to show which user id own the tile
        public string Owner { get; set; }
        
        //this is the counter to sort tile on board graveyard
        public int GraveYardCounter { get; set; }

        //this is the counter to sort tile on user active hand
        public int UserHandCounter { get; set; }
    }
}
