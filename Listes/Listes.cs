using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    Console.Clear();
    Console.WriteLine ("Manip Liste");

    //**************************************************************************************
    // Q1) Déclarer et initialiser une liste ListeImpairs qui contient tous les nombres entiers impairs entre 0 et 100.
    //**************************************************************************************

    Console.WriteLine("\nQ1) Déclaration et initialisation de ListeImpairs\n");

    // Déclaration et initialisation d'une liste d'entiers vide
    List<int> ListeImpairs = new List<int>();

    for(int i=1; i<100; i+=2) // Pour i allant de 1 à 100 exclus par pas de 2
    {
      ListeImpairs.Add(i); // Ajouter i à la fin de ListeImpairs
    }

    Affichage(ListeImpairs);
    //ListeImpairs.ForEach(Console.WriteLine);

    //**************************************************************************************
    // Q2) Déclarer et initialiser une liste ListeCarres qui contient les carrés de tous les éléments de ListeImpairs
    //**************************************************************************************

    Console.WriteLine("\nQ2) Déclaration et initialisation de ListeCarres\n");

    List<int> ListeCarres = new List<int>();
    
    foreach(int e in ListeImpairs) // Pour chaque élément de ListeImpairs
    {
      ListeCarres.Add(e*e); // Ajouter l'élément e au carré à ListeCarres
    }

    Affichage(ListeCarres);
    //ListeCarres.ForEach(Console.WriteLine);

    // Version condensée :
    //ListeImpairs.ForEach(i => ListeCarres.Add(i*i));
    
    //**************************************************************************************
    // Q3) Afficherle nombre d’éléments de ListeImpairset le nombre d’éléments de ListeCarres
    //**************************************************************************************

    Console.WriteLine("\nQ3) Le nombre d’éléments de chaque liste\n");

    Console.WriteLine("Il y a {0} élément dans ListeImpairs et {1} dans ListeCarres", ListeImpairs.Count, ListeCarres.Count);
    
    //**************************************************************************************
    // Q4) Afficher le premier élément de ListeCarres.
    //**************************************************************************************

    Console.WriteLine("\nQ4) Le premier élément de ListeCarres\n");

    Console.WriteLine("Le premier élément de ListeCarres est : {0}", ListeCarres[0]);

    //**************************************************************************************
    // Q5) Afficher le dernier élément de ListeImpairs et le dernier élément de ListeCarres
    //**************************************************************************************

    Console.WriteLine("\nQ5) Le dernier élément de ListeImpairs et le dernier élément de ListeCarres\n");
    
    Console.WriteLine("Le dernier élément de ListeImpairs est : {0} et le dernier élément de ListeCarres est : {1}", ListeImpairs[ListeImpairs.Count-1], ListeCarres[ListeCarres.Count-1]);

    //**************************************************************************************
    // Q6) Afficher uniquement les éléments de ListeCarres supérieurs à 100
    //**************************************************************************************

    Console.WriteLine("\nQ6) Les éléments de ListeCarres supérieurs à 100\n");

    List<int> SuperieurA100 = new List<int>();

    foreach(int e in ListeCarres) // Pour chaque élément de ListeCarres
    {
      if (e>100) // Si l'élément est plus grand que 100
      {
        SuperieurA100.Add(e); // Alors ajouter cette élément à la liste intermédiaire  SuperieurA100
      }
    }

    Affichage(SuperieurA100);
    // Version condensée :
    //ListeCarres.Where(i => i>100).ToList().ForEach(Console.WriteLine);

    //**************************************************************************************
    // Q7) Afficher uniquement les éléments de ListeCarres qui commencent par un 9.
    //**************************************************************************************

    Console.WriteLine("\nQ7) Les éléments de ListeCarres qui commencent par un 9\n");

    // Version 1 : En convertissant les int en string 

    //foreach(int e in ListeCarres)
    //{
    //  if(e.ToString()[0]=='9') Console.WriteLine(e);
    //}

    // Version 2 : En divisant par 10 jusqu'à n'avoir que le premier chiffre du nombre

    List<int> CommencentPar9 = new List<int>();

    int nb;
    foreach(int e in ListeCarres)
    {
      nb = e;
      while(nb>=10) nb/=10; 
      if(nb==9) CommencentPar9.Add(e);
    }

    Affichage(CommencentPar9);

    // Version condensée :
    //ListeCarres.Where(e => e.ToString()[0]=='9').ToList().ForEach(Console.WriteLine);
    
    //**************************************************************************************
    // Q8) Afficher les 8 premiers éléments de ListeCarres
    //**************************************************************************************

    Console.WriteLine("\nQ8) Les 8 premiers éléments de ListeCarres\n");

    // Version 1 : Avec une boucle for

    //for(int i=0; i<8; i++) // Pour i allant de 0 à 8 exclus par pas de 1
    //{
    //  Console.WriteLine(ListeCarres[i]);
    //}

    // Version 2 : Avec un getRange
    Affichage(ListeCarres.GetRange(0, 8));
    // Récupère une plage de la liste en commençant à la première position donnée (0) et en faisant +8.

    // Version condensée :
    //ListeCarres.Take(8).ToList().ForEach(Console.WriteLine);

    

    //**************************************************************************************
    // Q9) Afficher les 8 derniers éléments de ListeCarres
    //**************************************************************************************

    Console.WriteLine("\nQ9) Les 8 derniers éléments de ListeCarres\n");

    // Version 1 : Avec une boucle for
    //for(int i=ListeCarres.Count-9; i<ListeCarres.Count; i++) // Pour i allant de la taille de ListeCarres moins 9 à la taille de ListeCarres exclus par pas de 1
    //{
    //  Console.WriteLine(ListeCarres[i]);
    //}

    // Version 2 : Avec un getRange
    Affichage(ListeCarres.GetRange(ListeCarres.Count-9, 8));
    // Récupère une plage de la liste en commençant à la première position donnée (ListeCarres.Count-9) et en faisant +8.

    // Version condensée 1
    //ListeCarres.Skip(ListeCarres.Count - 8).ToList().ForEach(Console.WriteLine);

    // Version condensée 2
    //ListeCarres.TakeLast(8).ToList().ForEach(Console.WriteLine);

    //**************************************************************************************
    // Q10) Déclarer et initialiser une liste MultiplesDe3 qui contient tous les éléments de ListeCarres qui sont des multiples de trois.
    //**************************************************************************************

    Console.WriteLine("\nQ10) Déclaration et initialisation de liste MultiplesDe3\n");

    List<int> MultiplesDe3 = new List<int>();

    foreach(int e in ListeCarres)
    {
      if (e%3 == 0) MultiplesDe3.Add(e);
    }

    Affichage(MultiplesDe3);
    //MultiplesDe3.ForEach(Console.WriteLine);

    // Version condensée :
    //List<int> MultiplesDe3 = ListeCarres.Where(i => i%3==0).ToList();
    //MultiplesDe3.ForEach(Console.WriteLine);
    //MultiplesDe3.ForEach(i => ListeCarres.Remove(i));
    
    //**************************************************************************************
    // Q11) Supprimer de ListeCarres tous les multiples de 3
    //**************************************************************************************

    Console.WriteLine("\nQ11) Supprimer de ListeCarres tous les multiples de 3\n");

    foreach(int e in MultiplesDe3)
    {
      ListeCarres.Remove(e);
    }

    Affichage(ListeCarres);
    //ListeCarres.ForEach(Console.WriteLine);

    // Version condensée :
    //MultiplesDe3.ForEach(i => ListeCarres.Remove(i));
    
    //**************************************************************************************
    // Q12) Ajouter de nouveaux les multiples de 3 à la fin de ListeCarres.
    //**************************************************************************************

    Console.WriteLine("\nQ12) Ajouter de nouveaux les multiples de 3 à la fin de ListeCarres\n");

    ListeCarres.AddRange(MultiplesDe3);

    Affichage(ListeCarres);
  }

  //**************************************************************************************
  // Q13) Définir une fonction static void Affichage(List<int> Liste), qui prend en paramètre une liste d’entiers. Cette fonction permet d’afficher tous les éléments de la liste reçue en les séparant par des virgules.
  //**************************************************************************************

  static void Affichage(List<int> Liste)
  {
    Console.WriteLine(String.Join(", ", Liste));
  }
}