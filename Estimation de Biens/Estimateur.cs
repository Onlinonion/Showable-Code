using System;
using System.Text.RegularExpressions;

namespace c
{
    public class Terrain
    {
        public string Adresse;
        public float Superficie;
        public int NbCotesCLotures;
        public bool Riviere;

        public Terrain(string adresse, float superficie, int nbCotesCLotures, bool riviere)
        {
            Adresse = adresse;
            Superficie = superficie;
            NbCotesCLotures = nbCotesCLotures;
            Riviere = riviere;
        }
        public override string ToString()
        {
            string toString = String.Format("Adresse = {0}\n", this.Adresse);
            toString += String.Format("Superficie = {0}m²\n", this.Superficie);
            toString += String.Format("Nombre de côtés de la cloture = {0}\n", this.NbCotesCLotures);
            toString += String.Format("Présence d'une rivière = {0}", this.Riviere ? "Oui" : "Non");
            toString += String.Format("> VALEUR = {0}$\n", this.EvaluationValeur());
            return toString;
        }

        public float EvaluationValeur()
        {
            int facteur = 3000;

            if (this.Riviere) { facteur += 500; }
            if (this.NbCotesCLotures > 3) { facteur += 200; }

            if (Regex.IsMatch(this.Adresse, @"\bParis\b")) { facteur += 7000; }
            else if (Regex.IsMatch(this.Adresse, @"\bDinan\b")) { facteur += 2000; }

            return (int)this.Superficie * facteur - CoutFinirCloture();

        }
        public int CoutFinirCloture()
        {
            int CoutFinirCloture = 100;

            if (NbCotesCLotures > 3) { CoutFinirCloture += 200; }
            else { CoutFinirCloture += 100; }

            int CoutFinirClotures2 = (int)CoutFinirCloture;

            return CoutFinirClotures2;
        }

    }   
}
