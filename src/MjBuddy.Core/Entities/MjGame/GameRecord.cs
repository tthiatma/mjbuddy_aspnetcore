using System.ComponentModel.DataAnnotations.Schema;

namespace MjBuddy.Core.Entities.MjGame
{
    [Table("AppGameRecords")]
    public class GameRecord
    {
        public long Id { get; set; }
        public WindDirection CurrentWind { get; set; }
        public int TilesLeft { get; set; }
        public TileGame LastTile { get; set; }        
        public bool HaltMove { get; set; }
        public string PlayerTurn { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Player Player3 { get; set; }
        public Player Player4 { get; set; }
    }
}
