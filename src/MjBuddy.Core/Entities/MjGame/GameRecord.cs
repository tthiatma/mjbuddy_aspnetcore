namespace MjBuddy.Core.Entities.MjGame
{
    public class GameRecord
    {
        public WindDirection CurrentWind { get; set; }
        public int TilesLeft { get; set; }
        public TileGame LastTile { get; set; }        
        public bool HaltMove { get; set; }
        public string PlayerTurn { get; set; }
    }
}
