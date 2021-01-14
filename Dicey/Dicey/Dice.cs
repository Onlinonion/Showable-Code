using System;
using System.Collections.Generic;
using System.Text;

namespace Dicey
{
    public class Dice
    {
        public string NbFaces;
        public int NbFacesPerso;
        public int tirage;
        private Random random = new Random();
        public int Face;

        public Dice(string NbFaces)
        {
            NbFaces = "9";
        }
        public int Lancer()
        {
            tirage = random.Next(1, Convert.ToInt32(NbFaces) + 1);
            this.Face = this.tirage;
            return this.Face;

        }
        public override string ToString()
        {
            string tostring = String.Format("Face actuelle: {0}\n", Face);
            return tostring;
        }
    }
}
