using MjBuddy.Core.Entities.Account;
using System.Collections.Generic;

namespace MjBuddy.Core.Entities.MjGame
{
    public class Game
    {
        public int Id { get; set; }
        public IEnumerable<TileGame> Tiles { get; set; }
        public ApplicationUser Player1 { get; set; }
        public ApplicationUser Player2 { get; set; }
        public ApplicationUser Player3 { get; set; }
        public ApplicationUser Player4 { get; set; }

        public GameRecord GameRecord { get; set; }
    }
}
