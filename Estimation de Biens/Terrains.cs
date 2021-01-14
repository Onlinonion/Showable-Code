using System;

namespace c
{
    public class Program
    {
        static void Main(string[]args)
        {
            Terrain UnPremierTerrain = new Terrain("22 Rue des Moulineaux, 75005 Paris", 58f, 4, false);
            Terrain UnDeuxiemerTerrain = new Terrain("4 place Saint Jean, 22100 Dinan", 86.5f, 3, true);
            Terrain UnTroisiemeTerrain = new Terrain("38 avenue du Colonel Moutarde, 69001 Lyon", 25.2f, 2, false);

            Terrain[] CatalogueMaisons = new Terrain[] { UnPremierTerrain, UnDeuxiemerTerrain, UnTroisiemeTerrain };

            foreach (Terrain M in CatalogueMaisons)
            {
                Console.WriteLine(M);
            }
        }
    }
}

