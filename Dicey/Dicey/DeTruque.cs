using System;
using System.Collections.Generic;
using System.Text;

namespace Dicey
{
    public class DeTruque : Dice
    {
        public DeTruque()
        {
            NbFaces = "6";
        }
        public override void Lancer()
        {
            int rdm = Random.Next(1, 13);
            if (rdm <= 6)
                Face = 6;
            else if (rdm <= 8)
                Face = 5;
            else if (rdm <= 9)
                Face = 4;
            else if (rdm <= 10)
                Face = 3;
            else if (rdm <= 11)
                Face = 2;
            else if (rdm <= 12)
                Face = 1;
        }
    }
}
