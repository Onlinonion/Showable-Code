using System;
using System.Linq;

namespace JeuAllumettes
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbAllumettes, nbAllumettesRestantes;
            int choixJoueur, choixOrdinateur;
            Random random = new Random();

            Console.Write("Choisir un nombre d'allumettes : ");
            nbAllumettes = int.Parse(Console.ReadLine());

            nbAllumettesRestantes = nbAllumettes;

            Console.WriteLine(String.Concat(Enumerable.Repeat("|", nbAllumettesRestantes)));

            while (nbAllumettesRestantes > 0)
            {

                // Tour du joueur
                Console.Write("Combien d'allumettes souhaitez-vous prendre (1/2/3) ? : ");
                choixJoueur = int.Parse(Console.ReadLine());

                while (true)
                {
                    if (choixJoueur > 0 && choixJoueur < 4 && choixJoueur <= nbAllumettesRestantes)
                    {
                        nbAllumettesRestantes -= choixJoueur;
                        Console.WriteLine("Vous avez retiré {0} allumette(s)", choixJoueur);
                        Console.WriteLine(String.Concat(Enumerable.Repeat(" ", nbAllumettes - nbAllumettesRestantes)) +
                            String.Concat(Enumerable.Repeat("|", nbAllumettesRestantes)));
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Veuillez choisir un nombre valide d'allumettes");
                        continue;
                    }
                }


                if (nbAllumettesRestantes == 0)
                {
                    Console.WriteLine("Vous avez perdu");
                    break;
                }

                // Tour de l'ordinateur

                if (nbAllumettesRestantes <= 4 && nbAllumettesRestantes > 1)
                {
                    choixOrdinateur = nbAllumettesRestantes - 1;
                }

                else if (nbAllumettesRestantes == 1)
                {
                    choixOrdinateur = 1;
                }

                else
                {
                    choixOrdinateur = random.Next(1, 4);
                }

                Console.WriteLine("L'ordinateur a retiré {0} allumette(s)", choixOrdinateur);

                nbAllumettesRestantes -= choixOrdinateur;

                Console.WriteLine(String.Concat(Enumerable.Repeat(" ", nbAllumettes - nbAllumettesRestantes)) +
                   String.Concat(Enumerable.Repeat("|", nbAllumettesRestantes)));

                if (nbAllumettesRestantes == 0)
                {
                    Console.WriteLine("Vous avez gagné ! L'ordinateur a retiré la dernière allumette.");
                    break;
                }
            }
        }
    }
}
