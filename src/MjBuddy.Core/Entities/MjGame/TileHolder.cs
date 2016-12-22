namespace MjBuddy.Core.Entities.MjGame
{
    public enum TileHolder
    {
        //Tile is closed / belongs to the board
        None = 0,

        //Tile that user just picked from the board. User can throw or keep this tile
        UserPicked = 1,
        
        //Tile that is on player's hand and not showed to other player
        UserActive = 2,

        //Tile that user just thrown to board. This tile can be pong, kong, or chow
        UserThrown = 3,

        //Tile is kept by player when user chow,pong,kong, or flower
        UserInactive = 4,

        //Tile is open and thrown to the board
        Graveyard = 5
    }
}
