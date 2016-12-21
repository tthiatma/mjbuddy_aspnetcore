namespace MjBuddy.Core.Entities.MjGame
{
    public enum TileHolder
    {
        //Tile belongs to the board
        Board = 0,
        //Tile just picked from the board
        UserPicked = 1,
        //Tile that is on player's hand
        UserActive = 2,
        //Tile is kept by player
        UserGraveyard = 3,
        //Tile is open and thrown to the board
        BoardGraveyard = 4
    }
}
