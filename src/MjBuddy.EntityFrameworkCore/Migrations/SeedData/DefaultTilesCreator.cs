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
                    _context.Tiles.Add(new Tile { Name = TileName.DRAGON_GREEN, Image = "", ImageSmall = "", Type = TileFigure.Dragon, Value = TileValue.DragonGreen });
                    _context.Tiles.Add(new Tile { Name = TileName.DRAGON_RED, Image = "", ImageSmall = "", Type = TileFigure.Dragon, Value = TileValue.DragonRed });
                    _context.Tiles.Add(new Tile { Name = TileName.DRAGON_WHITE, Image = "", ImageSmall = "", Type = TileFigure.Dragon, Value = TileValue.DragonWhite });

                    _context.Tiles.Add(new Tile { Name = TileName.WIND_EAST, Image = "", ImageSmall = "", Type = TileFigure.Wind, Value = TileValue.WindEast });
                    _context.Tiles.Add(new Tile { Name = TileName.WIND_SOUTH, Image = "", ImageSmall = "", Type = TileFigure.Wind, Value = TileValue.WindSouth });
                    _context.Tiles.Add(new Tile { Name = TileName.WIND_WEST, Image = "", ImageSmall = "", Type = TileFigure.Wind, Value = TileValue.WindWest });
                    _context.Tiles.Add(new Tile { Name = TileName.WIND_NORTH, Image = "", ImageSmall = "", Type = TileFigure.Wind, Value = TileValue.WindNorth });

                    _context.Tiles.Add(new Tile { Name = TileName.MONEY_1, Image = "", ImageSmall = "", Type = TileFigure.Money, Value = TileValue.One });
                    _context.Tiles.Add(new Tile { Name = TileName.MONEY_2, Image = "", ImageSmall = "", Type = TileFigure.Money, Value = TileValue.Two });
                    _context.Tiles.Add(new Tile { Name = TileName.MONEY_3, Image = "", ImageSmall = "", Type = TileFigure.Money, Value = TileValue.Three });
                    _context.Tiles.Add(new Tile { Name = TileName.MONEY_4, Image = "", ImageSmall = "", Type = TileFigure.Money, Value = TileValue.Four });
                    _context.Tiles.Add(new Tile { Name = TileName.MONEY_5, Image = "", ImageSmall = "", Type = TileFigure.Money, Value = TileValue.Five });
                    _context.Tiles.Add(new Tile { Name = TileName.MONEY_6, Image = "", ImageSmall = "", Type = TileFigure.Money, Value = TileValue.Six });
                    _context.Tiles.Add(new Tile { Name = TileName.MONEY_7, Image = "", ImageSmall = "", Type = TileFigure.Money, Value = TileValue.Seven });
                    _context.Tiles.Add(new Tile { Name = TileName.MONEY_8, Image = "", ImageSmall = "", Type = TileFigure.Money, Value = TileValue.Eight });
                    _context.Tiles.Add(new Tile { Name = TileName.MONEY_9, Image = "", ImageSmall = "", Type = TileFigure.Money, Value = TileValue.Nine });

                    _context.Tiles.Add(new Tile { Name = TileName.BAMBOO_1, Image = "", ImageSmall = "", Type = TileFigure.Bamboo, Value = TileValue.One });
                    _context.Tiles.Add(new Tile { Name = TileName.BAMBOO_2, Image = "", ImageSmall = "", Type = TileFigure.Bamboo, Value = TileValue.Two });
                    _context.Tiles.Add(new Tile { Name = TileName.BAMBOO_3, Image = "", ImageSmall = "", Type = TileFigure.Bamboo, Value = TileValue.Three });
                    _context.Tiles.Add(new Tile { Name = TileName.BAMBOO_4, Image = "", ImageSmall = "", Type = TileFigure.Bamboo, Value = TileValue.Four });
                    _context.Tiles.Add(new Tile { Name = TileName.BAMBOO_5, Image = "", ImageSmall = "", Type = TileFigure.Bamboo, Value = TileValue.Five });
                    _context.Tiles.Add(new Tile { Name = TileName.BAMBOO_6, Image = "", ImageSmall = "", Type = TileFigure.Bamboo, Value = TileValue.Six });
                    _context.Tiles.Add(new Tile { Name = TileName.BAMBOO_7, Image = "", ImageSmall = "", Type = TileFigure.Bamboo, Value = TileValue.Seven });
                    _context.Tiles.Add(new Tile { Name = TileName.BAMBOO_8, Image = "", ImageSmall = "", Type = TileFigure.Bamboo, Value = TileValue.Eight });
                    _context.Tiles.Add(new Tile { Name = TileName.BAMBOO_9, Image = "", ImageSmall = "", Type = TileFigure.Bamboo, Value = TileValue.Nine });

                    _context.Tiles.Add(new Tile { Name = TileName.CIRCLE_1, Image = "", ImageSmall = "", Type = TileFigure.Circle, Value = TileValue.One });
                    _context.Tiles.Add(new Tile { Name = TileName.CIRCLE_2, Image = "", ImageSmall = "", Type = TileFigure.Circle, Value = TileValue.Two });
                    _context.Tiles.Add(new Tile { Name = TileName.CIRCLE_3, Image = "", ImageSmall = "", Type = TileFigure.Circle, Value = TileValue.Three });
                    _context.Tiles.Add(new Tile { Name = TileName.CIRCLE_4, Image = "", ImageSmall = "", Type = TileFigure.Circle, Value = TileValue.Four });
                    _context.Tiles.Add(new Tile { Name = TileName.CIRCLE_5, Image = "", ImageSmall = "", Type = TileFigure.Circle, Value = TileValue.Five });
                    _context.Tiles.Add(new Tile { Name = TileName.CIRCLE_6, Image = "", ImageSmall = "", Type = TileFigure.Circle, Value = TileValue.Six });
                    _context.Tiles.Add(new Tile { Name = TileName.CIRCLE_7, Image = "", ImageSmall = "", Type = TileFigure.Circle, Value = TileValue.Seven });
                    _context.Tiles.Add(new Tile { Name = TileName.CIRCLE_8, Image = "", ImageSmall = "", Type = TileFigure.Circle, Value = TileValue.Eight });
                    _context.Tiles.Add(new Tile { Name = TileName.CIRCLE_9, Image = "", ImageSmall = "", Type = TileFigure.Circle, Value = TileValue.Nine });
                }

                _context.Tiles.Add(new Tile { Name = TileName.FLOWER_NUMERIC_1, Image = "", ImageSmall = "", Type = TileFigure.Flower, Value = TileValue.FlowerNumericOne });
                _context.Tiles.Add(new Tile { Name = TileName.FLOWER_NUMERIC_2, Image = "", ImageSmall = "", Type = TileFigure.Flower, Value = TileValue.FlowerNumericTwo });
                _context.Tiles.Add(new Tile { Name = TileName.FLOWER_NUMERIC_3, Image = "", ImageSmall = "", Type = TileFigure.Flower, Value = TileValue.FlowerNumericThree });
                _context.Tiles.Add(new Tile { Name = TileName.FLOWER_NUMERIC_4, Image = "", ImageSmall = "", Type = TileFigure.Flower, Value = TileValue.FlowerNumericFour });

                _context.Tiles.Add(new Tile { Name = TileName.FLOWER_ROMAN_1, Image = "", ImageSmall = "", Type = TileFigure.Flower, Value = TileValue.FlowerRomanOne });
                _context.Tiles.Add(new Tile { Name = TileName.FLOWER_ROMAN_2, Image = "", ImageSmall = "", Type = TileFigure.Flower, Value = TileValue.FlowerRomanTwo });
                _context.Tiles.Add(new Tile { Name = TileName.FLOWER_ROMAN_3, Image = "", ImageSmall = "", Type = TileFigure.Flower, Value = TileValue.FlowerRomanThree });
                _context.Tiles.Add(new Tile { Name = TileName.FLOWER_ROMAN_4, Image = "", ImageSmall = "", Type = TileFigure.Flower, Value = TileValue.FlowerRomanFour });
            }

            _context.SaveChanges();
        }
    }
}
