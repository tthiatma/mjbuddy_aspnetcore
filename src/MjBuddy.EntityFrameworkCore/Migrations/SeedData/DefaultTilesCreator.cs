using MjBuddy.Core;
using MjBuddy.Core.Entities.MjGame;
using System.Linq;

namespace MjBuddy.EntityFrameworkCore.Migrations.SeedData
{
    public class DefaultTilesCreator
    {
        private MjBuddyDbContext _context;

        public DefaultTilesCreator(MjBuddyDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateTiles();
        }

        private void CreateTiles()
        {
            var tileCount = _context.Tiles.Count();
            var tileGameCount = _context.TileGames.Count();

            if (tileCount != 144 && tileGameCount == 0)
            {
                //add all tiles
                for (int i = 0; i < 4; i++)
                {
                    _context.Tiles.Add(new Tile { Name = TileName.DRAGON_GREEN, Image = "~/images/tiles/64px/dragon/dragon-green.png", ImageSmall = "~/images/tiles/50px/dragon/dragon-green.png", Type = TileFigure.Dragon, Value = TileValue.DragonGreen });
                    _context.Tiles.Add(new Tile { Name = TileName.DRAGON_RED, Image = "~/images/tiles/64px/dragon/dragon-chun.png", ImageSmall = "~/images/tiles/50px/dragon/dragon-chun.png", Type = TileFigure.Dragon, Value = TileValue.DragonRed });
                    _context.Tiles.Add(new Tile { Name = TileName.DRAGON_WHITE, Image = "~/images/tiles/64px/dragon/dragon-white.png", ImageSmall = "~/images/tiles/50px/dragon/dragon-white.png", Type = TileFigure.Dragon, Value = TileValue.DragonWhite });

                    _context.Tiles.Add(new Tile { Name = TileName.WIND_EAST, Image = "~/images/tiles/64px/wind/wind-east.png", ImageSmall = "~/images/tiles/50px/wind/wind-east.png", Type = TileFigure.Wind, Value = TileValue.WindEast });
                    _context.Tiles.Add(new Tile { Name = TileName.WIND_SOUTH, Image = "~/images/tiles/64px/wind/wind-south.png", ImageSmall = "~/images/tiles/50px/wind/wind-south.png", Type = TileFigure.Wind, Value = TileValue.WindSouth });
                    _context.Tiles.Add(new Tile { Name = TileName.WIND_WEST, Image = "~/images/tiles/64px/wind/wind-west.png", ImageSmall = "~/images/tiles/50px/wind/wind-west.png", Type = TileFigure.Wind, Value = TileValue.WindWest });
                    _context.Tiles.Add(new Tile { Name = TileName.WIND_NORTH, Image = "~/images/tiles/64px/wind/wind-north.png", ImageSmall = "~/images/tiles/50px/wind/wind-north.png", Type = TileFigure.Wind, Value = TileValue.WindNorth });

                    _context.Tiles.Add(new Tile { Name = TileName.MAN_1, Image = "~/images/tiles/64px/man/man1.png", ImageSmall = "~/images/tiles/50px/man/man1.png", Type = TileFigure.Man, Value = TileValue.One });
                    _context.Tiles.Add(new Tile { Name = TileName.MAN_2, Image = "~/images/tiles/64px/man/man2.png", ImageSmall = "~/images/tiles/50px/man/man2.png", Type = TileFigure.Man, Value = TileValue.Two });
                    _context.Tiles.Add(new Tile { Name = TileName.MAN_3, Image = "~/images/tiles/64px/man/man3.png", ImageSmall = "~/images/tiles/50px/man/man3.png", Type = TileFigure.Man, Value = TileValue.Three });
                    _context.Tiles.Add(new Tile { Name = TileName.MAN_4, Image = "~/images/tiles/64px/man/man4.png", ImageSmall = "~/images/tiles/50px/man/man4.png", Type = TileFigure.Man, Value = TileValue.Four });
                    _context.Tiles.Add(new Tile { Name = TileName.MAN_5, Image = "~/images/tiles/64px/man/man5.png", ImageSmall = "~/images/tiles/50px/man/man5.png", Type = TileFigure.Man, Value = TileValue.Five });
                    _context.Tiles.Add(new Tile { Name = TileName.MAN_6, Image = "~/images/tiles/64px/man/man6.png", ImageSmall = "~/images/tiles/50px/man/man6.png", Type = TileFigure.Man, Value = TileValue.Six });
                    _context.Tiles.Add(new Tile { Name = TileName.MAN_7, Image = "~/images/tiles/64px/man/man7.png", ImageSmall = "~/images/tiles/50px/man/man7.png", Type = TileFigure.Man, Value = TileValue.Seven });
                    _context.Tiles.Add(new Tile { Name = TileName.MAN_8, Image = "~/images/tiles/64px/man/man8.png", ImageSmall = "~/images/tiles/50px/man/man8.png", Type = TileFigure.Man, Value = TileValue.Eight });
                    _context.Tiles.Add(new Tile { Name = TileName.MAN_9, Image = "~/images/tiles/64px/man/man9.png", ImageSmall = "~/images/tiles/50px/man/man9.png", Type = TileFigure.Man, Value = TileValue.Nine });

                    _context.Tiles.Add(new Tile { Name = TileName.BAMBOO_1, Image = "~/images/tiles/64px/bamboo/bamboo1.png", ImageSmall = "~/images/tiles/50px/bamboo/bamboo1.png", Type = TileFigure.Bamboo, Value = TileValue.One });
                    _context.Tiles.Add(new Tile { Name = TileName.BAMBOO_2, Image = "~/images/tiles/64px/bamboo/bamboo2.png", ImageSmall = "~/images/tiles/50px/bamboo/bamboo2.png", Type = TileFigure.Bamboo, Value = TileValue.Two });
                    _context.Tiles.Add(new Tile { Name = TileName.BAMBOO_3, Image = "~/images/tiles/64px/bamboo/bamboo3.png", ImageSmall = "~/images/tiles/50px/bamboo/bamboo3.png", Type = TileFigure.Bamboo, Value = TileValue.Three });
                    _context.Tiles.Add(new Tile { Name = TileName.BAMBOO_4, Image = "~/images/tiles/64px/bamboo/bamboo4.png", ImageSmall = "~/images/tiles/50px/bamboo/bamboo4.png", Type = TileFigure.Bamboo, Value = TileValue.Four });
                    _context.Tiles.Add(new Tile { Name = TileName.BAMBOO_5, Image = "~/images/tiles/64px/bamboo/bamboo5.png", ImageSmall = "~/images/tiles/50px/bamboo/bamboo5.png", Type = TileFigure.Bamboo, Value = TileValue.Five });
                    _context.Tiles.Add(new Tile { Name = TileName.BAMBOO_6, Image = "~/images/tiles/64px/bamboo/bamboo6.png", ImageSmall = "~/images/tiles/50px/bamboo/bamboo6.png", Type = TileFigure.Bamboo, Value = TileValue.Six });
                    _context.Tiles.Add(new Tile { Name = TileName.BAMBOO_7, Image = "~/images/tiles/64px/bamboo/bamboo7.png", ImageSmall = "~/images/tiles/50px/bamboo/bamboo7.png", Type = TileFigure.Bamboo, Value = TileValue.Seven });
                    _context.Tiles.Add(new Tile { Name = TileName.BAMBOO_8, Image = "~/images/tiles/64px/bamboo/bamboo8.png", ImageSmall = "~/images/tiles/50px/bamboo/bamboo8.png", Type = TileFigure.Bamboo, Value = TileValue.Eight });
                    _context.Tiles.Add(new Tile { Name = TileName.BAMBOO_9, Image = "~/images/tiles/64px/bamboo/bamboo9.png", ImageSmall = "~/images/tiles/50px/bamboo/bamboo9.png", Type = TileFigure.Bamboo, Value = TileValue.Nine });

                    _context.Tiles.Add(new Tile { Name = TileName.PIN_1, Image = "~/images/tiles/64px/pin/pin1.png", ImageSmall = "~/images/tiles/50px/pin/pin1.png", Type = TileFigure.Pin, Value = TileValue.One });
                    _context.Tiles.Add(new Tile { Name = TileName.PIN_2, Image = "~/images/tiles/64px/pin/pin2.png", ImageSmall = "~/images/tiles/50px/pin/pin2.png", Type = TileFigure.Pin, Value = TileValue.Two });
                    _context.Tiles.Add(new Tile { Name = TileName.PIN_3, Image = "~/images/tiles/64px/pin/pin3.png", ImageSmall = "~/images/tiles/50px/pin/pin3.png", Type = TileFigure.Pin, Value = TileValue.Three });
                    _context.Tiles.Add(new Tile { Name = TileName.PIN_4, Image = "~/images/tiles/64px/pin/pin4.png", ImageSmall = "~/images/tiles/50px/pin/pin4.png", Type = TileFigure.Pin, Value = TileValue.Four });
                    _context.Tiles.Add(new Tile { Name = TileName.PIN_5, Image = "~/images/tiles/64px/pin/pin5.png", ImageSmall = "~/images/tiles/50px/pin/pin5.png", Type = TileFigure.Pin, Value = TileValue.Five });
                    _context.Tiles.Add(new Tile { Name = TileName.PIN_6, Image = "~/images/tiles/64px/pin/pin6.png", ImageSmall = "~/images/tiles/50px/pin/pin6.png", Type = TileFigure.Pin, Value = TileValue.Six });
                    _context.Tiles.Add(new Tile { Name = TileName.PIN_7, Image = "~/images/tiles/64px/pin/pin7.png", ImageSmall = "~/images/tiles/50px/pin/pin7.png", Type = TileFigure.Pin, Value = TileValue.Seven });
                    _context.Tiles.Add(new Tile { Name = TileName.PIN_8, Image = "~/images/tiles/64px/pin/pin8.png", ImageSmall = "~/images/tiles/50px/pin/pin8.png", Type = TileFigure.Pin, Value = TileValue.Eight });
                    _context.Tiles.Add(new Tile { Name = TileName.PIN_9, Image = "~/images/tiles/64px/pin/pin9.png", ImageSmall = "~/images/tiles/50px/pin/pin9.png", Type = TileFigure.Pin, Value = TileValue.Nine });
                }

                _context.Tiles.Add(new Tile { Name = TileName.FLOWER_NUMERIC_1, Image = "~/images/tiles/64px/flower/flower1a.png", ImageSmall = "~/images/tiles/50px/flower/flower1a.png", Type = TileFigure.Flower, Value = TileValue.FlowerNumericOne });
                _context.Tiles.Add(new Tile { Name = TileName.FLOWER_NUMERIC_2, Image = "~/images/tiles/64px/flower/flower2b.png", ImageSmall = "~/images/tiles/50px/flower/flower2b.png", Type = TileFigure.Flower, Value = TileValue.FlowerNumericTwo });
                _context.Tiles.Add(new Tile { Name = TileName.FLOWER_NUMERIC_3, Image = "~/images/tiles/64px/flower/flower3c.png", ImageSmall = "~/images/tiles/50px/flower/flower3c.png", Type = TileFigure.Flower, Value = TileValue.FlowerNumericThree });
                _context.Tiles.Add(new Tile { Name = TileName.FLOWER_NUMERIC_4, Image = "~/images/tiles/64px/flower/flower4d.png", ImageSmall = "~/images/tiles/50px/flower/flower4d.png", Type = TileFigure.Flower, Value = TileValue.FlowerNumericFour });

                _context.Tiles.Add(new Tile { Name = TileName.FLOWER_ROMAN_1, Image = "~/images/tiles/64px/flower/flower1.png", ImageSmall = "~/images/tiles/50px/flower/flower1.png", Type = TileFigure.Flower, Value = TileValue.FlowerRomanOne });
                _context.Tiles.Add(new Tile { Name = TileName.FLOWER_ROMAN_2, Image = "~/images/tiles/64px/flower/flower2.png", ImageSmall = "~/images/tiles/50px/flower/flower2.png", Type = TileFigure.Flower, Value = TileValue.FlowerRomanTwo });
                _context.Tiles.Add(new Tile { Name = TileName.FLOWER_ROMAN_3, Image = "~/images/tiles/64px/flower/flower3.png", ImageSmall = "~/images/tiles/50px/flower/flower3.png", Type = TileFigure.Flower, Value = TileValue.FlowerRomanThree });
                _context.Tiles.Add(new Tile { Name = TileName.FLOWER_ROMAN_4, Image = "~/images/tiles/64px/flower/flower4.png", ImageSmall = "~/images/tiles/50px/flower/flower4.png", Type = TileFigure.Flower, Value = TileValue.FlowerRomanFour });
            }

            _context.SaveChanges();
        }
    }
}
