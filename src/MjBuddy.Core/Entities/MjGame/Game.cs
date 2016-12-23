using MjBuddy.Core.Entities.Account;
using System.Collections.Generic;

namespace MjBuddy.Core.Entities.MjGame
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GameSetting Setting { get; set; }
    }
}
