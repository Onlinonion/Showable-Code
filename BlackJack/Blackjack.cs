using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace JeuBlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool stopJoueur = false;
            bool stopOrdinateur = false;
            bool finPartie = false;

            string choixJoueur;

            string name;
            Console.Write("Quel est votre prénom ? ");
            name = Console.ReadLine();

            int n;
            Console.WriteLine("Avec combien de paquets de cartes souhaitez-vous jouer ? ");
            Console.Write("Choix : ");
            n = int.Parse(Console.ReadLine());

            Dictionary<string, int> valeurCartes = new Dictionary<string, int>();
            for (int i=1;i<11;i++)
            {
                valeurCartes.Add(i.ToString(), i);
            }
            
            valeurCartes.Add("V", 10);
            valeurCartes.Add("D", 10);
            valeurCartes.Add("R", 10);

            List<string> joueurH = new List<string>();
            List<string> joueurO = new List<string>();

            // Paquet de cartes :

            List<string> paquet = new List<string>();
            List<string> famille = new List<string>(valeurCartes.Keys);

            for(int i=0;i<n*4;i++) { paquet.AddRange(famille); }

            paquet = paquet.OrderBy(x => Guid.NewGuid()).ToList();

            //paquet.ForEach(Console.WriteLine);

            for (int i=0;i<2;i++)
            {
                joueurH.Add(paquet[0]);
                paquet.RemoveAt(0);
                joueurO.Add(paquet[0]);
                paquet.RemoveAt(0);
            }

            Display(joueurH, joueurO, valeurCartes, name);

            while (!finPartie)
            {

                if (!stopJoueur)
                {
                    Console.WriteLine("Voulez-vous piocher une nouvelle carte ? : ");
                    Console.WriteLine("o - Oui");
                    Console.WriteLine("n - Non");
                    Console.Write("Choix : ");
                    choixJoueur = Console.ReadLine();

                    if (choixJoueur == "o")
                    {
                        Console.WriteLine("{0} : Je pioche", name);
                        joueurH.Add(paquet[0]);
                        paquet.RemoveAt(0);
                    }

                    else
                    {
                        Console.WriteLine("{0} : Je m'arrête là", name);
                        stopJoueur = true;
                    }
                }

                if (!stopOrdinateur)
                {
                    if (Score(joueurO, valeurCartes) <= 15)
                    {
                        joueurO.Add(paquet[0]);
                        paquet.RemoveAt(0);
                        Console.WriteLine("Ordinateur : Je pioche");
                    }

                    else
                    {
                        Console.WriteLine("Ordinateur : Je m'arrête là");
                        stopOrdinateur = true;
                    }
                }

                Display(joueurH, joueurO, valeurCartes, name);

                if (stopJoueur && stopOrdinateur) { finPartie = true; }
                if (Score(joueurO, valeurCartes) >= 21 || Score(joueurH, valeurCartes) >= 21) { finPartie = true; }
            }

            Console.WriteLine("{1} : {0} - Score = {2}", String.Join(" ", joueurH), name, Score(joueurH, valeurCartes));
            Console.WriteLine("Ordinateur : {0} - Score = {1}", String.Join(" ", joueurO), Score(joueurO, valeurCartes));

            if (Score(joueurH, valeurCartes) > 21 && Score(joueurO, valeurCartes) > 21) { Console.WriteLine("Match nul ! Vous avez tous les deux dépassé 21..."); }
            else if (Score(joueurH, valeurCartes) > 21) { Console.WriteLine("Dommage...Trop gourmand, vous dépassez 21. L'ordinateur gagne !"); }
            else if (Score(joueurO, valeurCartes) > 21) { Console.WriteLine("Bravo ! L'ordinateur s'est emporté, il dépasse 21 !"); }
            else if (Score(joueurH, valeurCartes)==21) { Console.WriteLine("Black Jack ! Félicitations !"); }
            else if (Score(joueurO, valeurCartes) == 21) { Console.WriteLine("Perdu ! C'est un Black Jack pour l'ordinateur ! Vous ne pouvez rien faire"); }
            else if (Score(joueurH, valeurCartes) > Score(joueurO, valeurCartes)) { Console.WriteLine("Bravo ! Vous êtes plus proche de 21 que l'ordinateur"); }
            else if (Score(joueurH, valeurCartes) < Score(joueurO, valeurCartes)) { Console.WriteLine("Perdu ! L'ordinateur est plus proche de 21 que vous"); }
            else { Console.WriteLine("Egalité ! Vous avez trouvé un adversaire à votre taille."); }
        }

        static int Score(List<string> cartes, Dictionary<string, int> valeurCartes)
        {
            int score = 0;
            foreach(string carte in cartes)
            {
                score += valeurCartes[carte];
            }

            if (cartes.Contains("1") && score <= 10) { score += 10; }
            return score;
        }

        static void Display(List<string> cartesJoueur, List<string> cartesOrdinateur, Dictionary<string, int> valeurCartes, string name)
        {
            Console.WriteLine("({2} pts) {1} : {0}", String.Join(" ", cartesJoueur), name, Score(cartesJoueur, valeurCartes));
            Console.WriteLine("Ordinateur : ? {0}", String.Join(" ", cartesOrdinateur.GetRange(1, cartesOrdinateur.Count - 1)));

        }
    }
}
