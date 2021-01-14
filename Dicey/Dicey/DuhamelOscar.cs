using System;

namespace Dicey
{
    class DuhamelOscar
    {
        static void Main(string[] args)
        {
            int quit = -1;
            Jeu jeu = new Jeu();

            do
            {
            

                Console.Write("Rejouer?\n1 - Oui\n2 - Non\n");
                quit = Convert.ToInt32(Console.ReadLine());
            } while (quit != 2);
        }
    }
}
