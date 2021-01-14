using System;
using System.Collections.Generic;
using System.Text;

namespace MiniVilles
{
    class Game
    {
        public int CreationdePile()
        {
            int NbdeCartesdansPile;

            Console.WriteLine("Combien de cartes voulez vous dans votre paquet?");
            NbdeCartesdansPile = Convert.ToInt32(Console.ReadLine());
            return NbdeCartesdansPile;
        }

    }
}
