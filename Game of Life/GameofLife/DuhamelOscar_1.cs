using System;

namespace GameofLife
{
    class DuhamelOscar
    {

        static void Main()
        {

            Game game = new Game(30, 150);
            game.RunGameConsole();
        }
    }
}
