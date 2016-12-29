using System.ComponentModel.DataAnnotations.Schema;

namespace MjBuddy.Core.Entities.MjGame
{
    [Table("AppGameSettings")]
    public class GameSetting
    {
        public long Id { get; set; }
        public Game Game { get; set; }
        public Setting Setting { get; set; }
    }
}
