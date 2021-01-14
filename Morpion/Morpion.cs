using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    class Program
    {
        static void Main()
        {
            // Créer le plateau de jeu
            Dictionary<string, string> game = new Dictionary<string, string>(){
                {"A1", " "},{"A2", " "},{"A3", " "},{"B1", " "},{"B2", " "},{"B3", " "},
                {"C1", " "},{"C2", " "},{"C3", " "}
            };

            List<string> locations = game.Keys.ToList();

            // Afficher le plateau
            Console.WriteLine("\n# Jeu du Tic Tac Toe #\n");
            Display(game);

            string choice;
            Random random = new Random();

            // Tant qu'il existe des emplacements libres dans la grille
            while (locations.Any())
            {
                while (true)
                {
                    Console.Write("\n[Joueur] Choisissez un emplacement : ");
                    choice = Console.ReadLine();
                    if (locations.Contains(choice))
                    {
                        break;
                    }
                }
                locations.Remove(choice);

                // Afficher une croix dans la case du joueur 
                game[choice] = "X";
                Display(game);
                if (EndGame(game, choice))
                {
                    Console.WriteLine("[Joueur] Victoire !!");
                    break;
                }

                if (!locations.Any())
                {
                    Console.WriteLine("La partie se termine sur une égalité...");
                    break;
                }

                // Choix aléatoire de l'IA
                Console.WriteLine("[IA] Je réfléchis ... ");
                System.Threading.Thread.Sleep(1000);

                int index = random.Next(locations.Count);
                choice = locations[index];
                Console.WriteLine("[IA] Je joue en " + choice);
                game[locations[index]] = "O";
                locations.RemoveAt(index);
                Display(game);
                if (EndGame(game, choice))
                {
                    Console.WriteLine("[IA] Je suis incroyable !");
                    break;
                }
            }

            Console.WriteLine("Appuyez sur 'o' pour lancer une nouvelle partie: ");
            string read = Console.ReadLine();
            if (read == "o") Main();
        }

        static void Display(Dictionary<string, string> game)
        {
            // Afficher le plateau de jeu

            List<string> lines = new List<string> { "A", "B", "C" };
            List<string> columns = new List<string> { "1", "2", "3" };

            string sep = "   " + string.Concat(Enumerable.Repeat("+---", 3)) + "+";
            string coord;

            Console.WriteLine("{0,6}{1,4}{2,4}", 1, 2, 3);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(sep);
                Console.Write(String.Format("{0,2} ", lines[i]));
                for (int j = 0; j < 3; j++)
                {
                    coord = lines[i] + columns[j];
                    Console.Write(String.Format("| {0} ", game[coord]));
                }
                Console.Write("|\n");
            }
            Console.WriteLine(sep);
        }

        static bool EndGame(Dictionary<string, string> game, string choice)
        {
            string symbole = game[choice];
            List<string> lines = new List<string> { "A", "B", "C" };
            List<string> columns = new List<string> { "1", "2", "3" };

            char l = choice[0];
            char c = choice[1];

            List<string> line = Enumerable.Repeat(l, 3).ToList().Zip(columns, (i, j) => i + j).ToList();
            List<string> col = lines.Zip(Enumerable.Repeat(c, 3).ToList(), (i, j) => i + j).ToList();
            List<string> diag1 = new List<string> { "A1","B2","C3"};
            List<string> diag2 = new List<string> { "A3","B2","C1"};

            return (Count3Marks(game, symbole, line) ||
                Count3Marks(game, symbole, col) ||
                Count3Marks(game, symbole, diag1) ||
                Count3Marks(game, symbole, diag2));
        }

        static bool Count3Marks(Dictionary<string, string> game, string symbole, List<string> l)
        {
            int marksCount = 0;

            foreach (string coord in l)
            {
                if (game[coord] == symbole) { marksCount++; }
            }

            return marksCount == 3 ? true : false;
        }
    }
}
