using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace SlidePuzzle
{
    class SlidePuzzleBoard
    {
        /*
         * Attributes:
         *      BoundedGrid
         *      ImageList
         *      Random generator
         *      int myBlankValue
         * Behaviors:
         *      initBoard
         *      bool Winner
         *      Paint
         *      bool Move (int row, int col)
         *      private swap(Location loc1, Location loc2)
         */
        private Size myTileSize;
        private BoundedGrid<Tile> myGrid;
        private List<Image> myImages;
        private Random rng = new Random();
        private int myBlankValue;
        public SlidePuzzleBoard (List<Image> tileImages, int rows, int columns)
        {
            //Initialize instance variables, set tile positions in the board, and then scramble the tiles.
            myGrid = new BoundedGrid<Tile>(rows, columns);
            myImages = tileImages;
            myTileSize = myImages[0].Size;
            myBlankValue = rows * columns - 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int value = i * columns + j;
                    Tile t = new Tile(myTileSize, new Location(j, i), tileImages[value], value);
                    myGrid.put(new Location(j, i), t);
                }
            }
            ScrambleTiles();
        }

        public void Paint(Graphics g)
        {
            //Paints the tile set in each avalable location in the board.
            List<Location> locs = myGrid.getOccupiedLocations();
            foreach (Location location in locs)
            {
                 myGrid.get(location).Paint(g);
            }
        }

        public void ScrambleTiles()
        {
            //Randomly swap tiles 100 times.
            for (int i = 0; i <= 100; i++)
            {
                List<Location> availableLocs = new List<Location>();
                Location blankTile = new Location(0, 0);
                List<Location> locs = myGrid.getOccupiedLocations();
                foreach (Location location in locs)
                {
                    if (myGrid.get(location).getValue() == myBlankValue)
                        blankTile = location;
                }
                for (int j = 0; j < 360; j += 90)
                {
                    if (myGrid.isValid(blankTile.getAdjacentLocation(j)))
                        availableLocs.Add(blankTile.getAdjacentLocation(j));
                }
                int randomIndex = rng.Next(availableLocs.Count);
                Swap(availableLocs[randomIndex], blankTile);
            }
        }

        public bool Move(int row, int col)
        {
            //Check to see if move is valid. If not, return false. If it is valid, return true.
            Location clickedLoc = new Location(col, row);
            if (!(myGrid.isValid(clickedLoc)))
                return false;
            Location blankTile = new Location(0, 0);
            List<Location> locs = myGrid.getOccupiedLocations();
            foreach (Location location in locs)
            {
                if (myGrid.get(location).getValue() == myBlankValue)
                    blankTile = location;
            }
            for (int i = 0; i < 360; i += 90)
            {
                if (blankTile.getAdjacentLocation(i).equals(clickedLoc))
                    break;
                if (i + 90 >= 360)
                    return false;
            }
            Swap(clickedLoc, blankTile);
            return true;
        }

        public bool Winner()
        {
            //Check to see if each sequential tile in the grid has the correct value and return true if they do carry correct values.
            int value = 0;
            for (int i = 0; i < myGrid.getNumRows(); i++)
            {
                for (int j = 0; j < myGrid.getNumCols(); j++)
                {
                    if (myGrid.get(new Location(j, i)).getValue() != value)
                        return false;
                    else value++;
                }
            }
            return true;
        }

        private void Swap(Location loc1, Location loc2)
        {
            //Put tiles in each others' places and sets their locations to their new locations in the grid.
            Tile temp = myGrid.put(loc1, myGrid.get(loc2));
            myGrid.get(loc1).setLocation(loc1);
            myGrid.put(loc2, temp);
            myGrid.get(loc2).setLocation(loc2);
        }
    }
}
