public class GenerateurQuestions
{
    public void GenererQuestionsDepuisCSV(string cheminFichierCSV)
    {
        if (File.Exists(cheminFichierCSV)) //Vérifier si le fichier csv existe
        {
            string[] lignes = File.ReadAllLines(cheminFichierCSV); //Lire chaques lignes et les stocker dans un tableau de chaines (string[]) appelé lignes

            foreach (string ligne in lignes) //Parcourir chaques lignes du csv
            {
                string[] colonnes = ligne.Split(';'); //Diviser chaque ligne en colonnes en utilisant le point-virgule comme délimiteur

                if (colonnes.Length == 3) //Cette condition vérifie si chaque ligne a le bon format, c'est-à-dire si elle contient trois colonnes : question, réponses et réponse correcte
                {
                    string question = colonnes[0];                  //Extraction de la question à partir de la première colonne
                    string reponses = colonnes[1];                  //Extraction des réponses à partir de la deuxième colonne
                    int reponseCorrecte = int.Parse(colonnes[2]);   //Extraction de la réponse correcte à partir de la troisième colonne et conversion en entier

                    string[] optionsReponses = reponses.Split('/'); //créer un nouveau tableau de chaines qui s'appelle optionReponses dans lequel on va y mettre les diférentes reponses proposées dans le csv qui sont séparées par /

                    Console.WriteLine($"Question : {question}");        //Afficher la question

                    for (int i = 0; i < optionsReponses.Length; i++)    //Pour chaques questions afficher les différentes réponses
                    {
                        Console.WriteLine($"{i + 1}. {optionsReponses[i]}");
                    }

                    Console.Write("Votre réponse : ");                  //Afficher "Votre réponse : "

                    GestionReponse.CorrigerReponse(reponseCorrecte);
                }
                else
                {
                    Console.WriteLine("La ligne du fichier CSV n'a pas le bon format.\n");
                }
            }
        }
        else
        {
            Console.WriteLine("Le fichier CSV n'existe pas.");
        }
    }

}
