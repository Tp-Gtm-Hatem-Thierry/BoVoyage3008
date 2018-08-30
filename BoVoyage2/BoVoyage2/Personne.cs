using System;
using System.IO; // espace de nom pour l'utilisation de liste sous forme de fichier si besoin

public class Personne // renommage de Class1 en Personne
{
    public abstract Personne() // classe abstraite qui nous envoie sur les classe Client et Participant
    {
        Personne.Client = new Client;
        Personne.Participant = news Participant; // à corriger
	}
}
