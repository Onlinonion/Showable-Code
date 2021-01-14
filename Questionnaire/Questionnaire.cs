using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        Algo1();
        Algo2();
        Algo3();
        Algo4();
        Algo5();
        Algo6();
        Algo7();
        Console.ReadLine();
    }

    static void Algo1()
    {
        // Le message "Bonjour" suivi du prénom de l'utilisateur s’affiche à l’écran

        Console.WriteLine("\nAlgo 1\n"); 
        
        string prenom;
        Console.Write("Quel est votre prénom ? ");
        prenom = Console.ReadLine();
        Console.WriteLine("Bonjour {0}", prenom);
    }

    static void Algo2()
    {
        // Le message "Vous avez X frères et sœurs" s'affiche avec X 
        // la somme du nombre de frères et du nombre de sœurs de l'utilisateur.

        Console.WriteLine("\nAlgo 2\n");

        int NbFreres, NbSoeurs;
        Console.Write("Combien avez-vous de frères ? ");
        NbFreres = int.Parse(Console.ReadLine());
        Console.Write("Combien avez-vous de soeurs ? ");
        NbSoeurs = int.Parse(Console.ReadLine());
        Console.WriteLine("Vous avez {0} frères et soeurs", NbFreres+ NbSoeurs);
    }

    static void Algo3()
    {
        // Un message s’affiche pour dire à l'utilisateur 
        // si son prénom commence par la lettre « A » ou non

        Console.WriteLine("\nAlgo 3\n");

        string prenom;
        Console.Write("Quel est votre prénom ? ");
        prenom = Console.ReadLine();

        if (prenom.StartsWith("A") || prenom.StartsWith("a"))
        {
            Console.WriteLine("Votre prénom commence par un A");
        }
        else
        {
            Console.WriteLine("Votre prénom ne commence pas par un A");
        }
    }

    static void Algo4()
    {
        // À partir de l'âge de l'utilisateur, un message s'affiche 
        // pour lui dire s'il est majeur ou non. 

        Console.WriteLine("\nAlgo 4\n");

        int age;
        Console.Write("Quel âge avez-vous ? ");
        age = int.Parse(Console.ReadLine());

        if (age >= 18) { Console.WriteLine("Vous êtes majeur."); }
        else { Console.WriteLine("Vous êtes mineur."); }
    }

    static void Algo5()
    {
        //À partir d'un nombre saisi, un message affiche la table 
        // de multiplication de ce nombre pour les facteurs de 1 à 10

        Console.WriteLine("\nAlgo 5\n");

        int nombre;
        Console.Write("Choisissez un nombre dont vous souhaitez connaître la table de multiplication ? ");
        nombre = int.Parse(Console.ReadLine());

        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine("{0}x{1}={2}", nombre, i, nombre * i);
        }
    }

    static void Algo6()
    {
        //À partir d'un nombre x saisi par l'utilisateur, un carré de côté 
        // x est dessiné à l'écran en utilisant les caractètes '+' et '-' 

        Console.WriteLine("\nAlgo 6\n");
        int x;
        Console.Write("Quelle valeur pour x pour le tracé d'un carré ? ");
        x = int.Parse(Console.ReadLine());

        string sep = "+" + string.Concat(Enumerable.Repeat("-", x)) + "+";
        Console.WriteLine(sep);
        for (int i=0;i<x-2;i++)
        {
            Console.WriteLine("|{0}|", new string(' ', x));
        }
        Console.WriteLine(sep);
    }

    static void Algo7()
    {
        // À partir du prénom de l'utilisateur et d'une lettre de l'alphabet, 
        // un message s'affiche pour dire à l'utilisateur combien de fois 
        // cette lettre est présente dans son prénom 

        Console.WriteLine("\nAlgo 7\n");

        string prenom;
        Console.Write("Quel est votre prénom ? " );
        prenom = Console.ReadLine();

        char lettre;
        Console.Write("Choisissez une lettre ? ");
        lettre = Console.ReadKey().KeyChar;

        int count = prenom.Count(f => f == lettre);

        Console.WriteLine("\nIl y a {0} fois la lettre {1} dans {2}",count,lettre,prenom);
    }

}