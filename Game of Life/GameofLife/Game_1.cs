using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GameofLife
{
    struct Coords
    {
        public int _x { get; set; }
        public int _y { get; set; }

        public Coords (int x, int y)
        {
            _x = x;
            _y = y;
        }
    }

    class Game
    {
        public Grid grid;
        public int nbCells;
        public int nbIterations;
        private readonly List<Coords> AliveCellsCoords = new List<Coords>();
        public Game(int nbCells, int nbIterations)
        {
            this.nbCells = nbCells;
            this.nbIterations = nbIterations;
            List<Coords> aliveCells = new List<Coords>
            {
                new Coords(7, 1),
                new Coords(8, 1),
                new Coords(7, 2),
                new Coords(8, 2),

                new Coords(1, 5),
                new Coords(1, 6),
                new Coords(2, 5),
                new Coords(2, 6),

                new Coords(11, 7),
                new Coords(11, 8),
                new Coords(12, 7),
                new Coords(12, 8),

                new Coords(5, 12),
                new Coords(6, 12),
                new Coords(5, 11),
                new Coords(6, 11),

                new Coords(5, 4),
                new Coords(6, 4),
                new Coords(7, 4),
                new Coords(8, 4),

                new Coords(5, 9),
                new Coords(6, 9),
                new Coords(7, 9),
                new Coords(8, 9),

                new Coords(4, 5),
                new Coords(4, 6),
                new Coords(4, 7),
                new Coords(4, 8),

                new Coords(9, 5),
                new Coords(9, 6),
                new Coords(9, 7),
                new Coords(9, 8),

                new Coords(7, 5),
                new Coords(6, 6),
                new Coords(8, 7),
            };

            grid = new Grid(nbCells, aliveCells);
        }
        public void RunGameConsole()
        {
            grid.DisplayGrid();
            Thread.Sleep(50);
            for (int i = 0; i < nbIterations; i++)
            {
                grid.UpdateGrid();
                grid.DisplayGrid();
                Thread.Sleep(300);
            }
        }
    }
}
