using System.ComponentModel.DataAnnotations.Schema;

namespace MjBuddy.Core.Entities.MjGame
{
    [Table("AppGames")]
    public class Game
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Setting Setting { get; set; }
    }
}
