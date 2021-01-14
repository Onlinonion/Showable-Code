using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {

    //**************************************************************************************
    // Q1) Déclarer et initialiser une liste Fruits contenant les éléments "Banane", "Pomme","Kiwi", "Orange", "Melon","Poire","Mangue".
    //**************************************************************************************

    List<string> Fruits = new List<string>() {"Banane", "Pomme","Kiwi", "Orange", "Melon","Poire","Mangue"};

    //**************************************************************************************
    // Q2) Déclarer et initialiser à vide un dictionnaire CorbeilleFruits qui acceptera comme clés des chaînes de caractères et comme valeurs des entiers.
    //**************************************************************************************

    Dictionary<string,int> CorbeilleFruits = new Dictionary<string,int>();

    //**************************************************************************************
    // Q3) Déclarer et initialiser un objet Random.
    //**************************************************************************************

    Random random = new Random();

    //**************************************************************************************
    // Q4) Pour chaque élément de la liste Fruits,ajouter un élément dans CorbeilleFruits ayant pour clé l’élément de la liste Fruits considéré et comme valeur un nombre aléatoire entre 0 et 10.
    //**************************************************************************************

    foreach(string f in Fruits)
    {
      CorbeilleFruits.Add(f,random.Next(0,11));
    }

    // Version condensée:
    //Fruits.ForEach(f => CorbeilleFruits.Add(f,random.Next(0,11)));

    //**************************************************************************************
    // Q5) Afficher pour chaque élément de CorbeilleFruits "J’ai X Y" avec Y le fruit et X la quantité associée.
    //**************************************************************************************

    // Version 1 : A partir du dictionnaire CorbeilleFruits
    foreach(var kvp in CorbeilleFruits)
    {
      Console.WriteLine("J'ai {0} {1}", kvp.Value, kvp.Key);
    }

    // Version 2 : A partir de la liste Fruits
    //foreach(string f in Fruits)
    //{
    //  Console.WriteLine("J'ai {0} {1}", CorbeilleFruits[f], f);
    //}

    //**************************************************************************************
    // Q6) Afficher le nombre total de fruits de CorbeilleFruits pour toutes les clés
    //**************************************************************************************

    // Version 1 : A partir de la liste Fruits
    //int TotalFruit = 0;
    //foreach(string f in Fruits)
    //{
    //  TotalFruit += CorbeilleFruits[f];
    //}
    //Console.WriteLine("Somme = {0}",TotalFruit);

    // Version 2 : A partir du dictionnaire CorbeilleFruits

    //TotalFruit = 0;
    //foreach(var kvp in CorbeilleFruits)
    //{
    //  TotalFruit += kvp.Value;
    //}
    //Console.WriteLine("Somme = {0}", TotalFruit);

    // Version 3 : A partir de la liste des valeurs du dictionnaire CorbeilleFruits
    Console.WriteLine("Le nombre de total de fruits dans la corbeille : {0}", CorbeilleFruits.Values.Sum());

    //**************************************************************************************
    // Q7) Afficher "J’ai X pomme(s)" avec X la valeur associée à la clé "Pomme" dans CorbeilleFruits
    //**************************************************************************************

    Console.WriteLine("J’ai {0} pomme{1}", CorbeilleFruits["Pomme"], CorbeilleFruits["Pomme"] > 1 ? "s" : "");

    //**************************************************************************************
    // Q8) Déclarer et initialiser une liste d’entiers NbLettres qui contient le nombre de lettres de chaque élément de Fruits.
    //**************************************************************************************

    List<int> NbLettres = new List<int>();

    foreach(string f in Fruits)
    {
      NbLettres.Add(f.Length);
    }

    //**************************************************************************************
    // Q9) Ajouter à chaque valeur de CorbeilleFruits le nombre de lettres de sa clé. Exemple : Pour la clé Banane, ajouter 6 à la valeur associée.
    //**************************************************************************************

    // Version 1 : En utilisant NbLettres
    int i = 0;
    foreach(string f in Fruits)
    {
      CorbeilleFruits[f] += NbLettres[i];
      i++;
    }

    // Version 2 : Sans NbLettres

    foreach(string f in Fruits)
    {
      CorbeilleFruits[f] += f.Length;
    }

    //**************************************************************************************
    // Q10) Supprimer de CorbeilleFruits les informations relatives à la clé "Mangue".
    //**************************************************************************************

    Console.WriteLine("Je retire Mangue de la corbeille");
    CorbeilleFruits.Remove("Mangue");

    //**************************************************************************************
    // Q11) Afficher "Il y a X fruits dans la Corbeille de fruits" avec X le nombre de clés de CorbeilleFruits
    //**************************************************************************************

    Console.WriteLine("Il y a {0} fruits différents dans la corbeille", CorbeilleFruits.Count);

    //**************************************************************************************
    // Q12) Ajouter à CorbeilleFruits un nouvel élément de clé "Ananas" et de valeur 6.
    //**************************************************************************************

    CorbeilleFruits.Add("Ananas",6);

    foreach(var kvp in CorbeilleFruits)
    {
      Console.WriteLine("J'ai {0} {1}", kvp.Value, kvp.Key);
    }

    //**************************************************************************************
    // Q13) Afficher uniquement les clés de CorbeilleFruits pour lesquelles la valeur associée est supérieure ou égale à 10.
    //**************************************************************************************
    Console.WriteLine("Les fruits pour lesquels la valeur est supérieure à 10 sont : ");
    foreach(var kvp in CorbeilleFruits)
    {
      if(kvp.Value >= 15) Console.WriteLine(" - {0}",kvp.Key);
    }
  }
}