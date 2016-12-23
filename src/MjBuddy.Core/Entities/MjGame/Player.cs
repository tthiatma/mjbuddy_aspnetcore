using MjBuddy.Core.Entities.Account;
using System.Collections.Generic;

namespace MjBuddy.Core.Entities.MjGame
{
    public class Player
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public WindDirection Wind { get; set; }
        public bool IsPlaying { get; set; }
        public bool CanThrowTile { get; set; }
        public bool CanDoNoFlower { get; set; }
        public bool CanPickTile { get; set; }
        public virtual int CurrentPoint { get; set; }
        public int ActiveTileCount { get; set; }
        public int InActiveTileCount { get; set; }
        public Player TopPlayer { get; set; }
        public Player LeftPlayer { get; set; }
        public Player RightPlayer { get; set; }
        public bool IsTileAutoSort { get; set; }
        public List<TileGame> ActiveTiles { get; set; }
        public List<TileGame> InActiveTiles { get; set; }
        //user credential information
        public ApplicationUser UserAccount { get; set; }
    }
}
