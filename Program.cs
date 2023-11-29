using System;

class Program
{
    static void Main()
    {
        string cheminFichierCSV = $@"QuestionsExample.csv";

        Welcome.AfficherBonjour();

        var generateur = new GenerateurQuestions();
        generateur.GenererQuestionsDepuisCSV(cheminFichierCSV);

        Console.ReadLine();
    }
}
