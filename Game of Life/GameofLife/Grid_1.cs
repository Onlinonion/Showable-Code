using System;
using System.Collections.Generic;
using System.Text;

namespace GameofLife
{
    class Grid
    {
        private int _n;
        public int n { get { return _n; } set { _n = value; } }
        Cells[,] TabCells;

        public Grid(int nbCells, List<Coords> AliveCellsCoords)
        {
            this.n = nbCells;
            this.TabCells = new Cells[n, n];
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    if (AliveCellsCoords.Contains(new Coords(x, y)))
                    {
                        TabCells[x, y] = new Cells(true);
                    }
                    else
                    {
                        TabCells[x, y] = new Cells(false);
                    }
                }
            }
        }
        public int getNbAliveNeighboor(int i, int j)
        {
            List<Coords> validCoords = GetCoordsCellsAlive(i, j);

            return validCoords.Count;
        }
        public List<Coords> getCoordsNeighboors(int i, int j)
        {
            List<Coords> neighboorsCoords = new List<Coords>();
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    int xCoord = x + j - 1;
                    int yCoord = y + i - 1;

                    if ((xCoord < n) && (xCoord >= 0) && (yCoord < n) && (yCoord >= 0))
                    {
                        neighboorsCoords.Add(new Coords(xCoord, yCoord));
                    }
                }

            }
            neighboorsCoords.Remove(new Coords(i, j));
            return neighboorsCoords;
        }
        public List<Coords> GetCoordsCellsAlive(int i, int j)
        {
            List<Coords> neighboors = getCoordsNeighboors(i, j);
            List<Coords> validCoords = new List<Coords>();

            foreach (Coords coord in neighboors)
            {
                if (TabCells[coord._x, coord._y]._isAlive)
                    validCoords.Add(coord);
            }
        return validCoords;
        }

        public void DisplayGrid()
        {
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" {0} ", TabCells[i, j]._isAlive ? "▓" : Convert.ToString(getNbAliveNeighboor(i, j)));
                }
            }
        }
        public void UpdateGrid()
        {
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    if (getNbAliveNeighboor(x, y) == 3)
                        TabCells[x, y].ComeAlive();
                    else if (getNbAliveNeighboor(x, y) > 3 || getNbAliveNeighboor(x, y) < 2)
                        TabCells[x, y].PassAway();
                }
            }
            foreach (Cells entry in TabCells)
                entry.Update();
        }
    }
}
