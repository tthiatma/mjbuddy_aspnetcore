using System.ComponentModel.DataAnnotations.Schema;

namespace MjBuddy.Core.Entities.MjGame
{
    [Table("AppSettings")]
    public class Setting
    {
        public long Id { get; set; }
        public bool SkipInitialFlowerSwapping { get; set; }
        public int TurnCountDownInSecond { get; set; }
    }
}
