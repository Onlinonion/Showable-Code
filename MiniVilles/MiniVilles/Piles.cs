using System;
using System.Collections.Generic;
using System.Text;

namespace MiniVilles
{
    public class Piles
    {
        int NbdePossibilitésdansPile = 6;
        int Pile;

        public Piles()
        {
            List<Cards> cartes = new List<Cards>();

            //Pile = NbdeCartesdansPile;

            cartes.Add(new Cards() { Nomdecarte = "Champ de blé", PileId = 1 });
            cartes.Add(new Cards() { Nomdecarte = "Ferme", PileId = 2 });
            cartes.Add(new Cards() { Nomdecarte = "Boulangerie", PileId = 3 });
            cartes.Add(new Cards() { Nomdecarte = "Café", PileId = 4 });
            cartes.Add(new Cards() { Nomdecarte = "Restaurant", PileId = 5 });
            cartes.Add(new Cards() { Nomdecarte = "Stade", PileId = 6 });
            cartes.Add(new Cards() { Nomdecarte = "Superette", PileId = 7 });
            cartes.Add(new Cards() { Nomdecarte = "Forêt", PileId = 8 });

        }

    }

}
