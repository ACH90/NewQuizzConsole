public class GenerateurQuestions
{
    public void GenererQuestionsDepuisCSV(string cheminFichierCSV)
    {
        if (File.Exists(cheminFichierCSV)) //V�rifier si le fichier csv existe
        {
            string[] lignes = File.ReadAllLines(cheminFichierCSV); //Lire chaques lignes et les stocker dans un tableau de chaines (string[]) appel� lignes

            foreach (string ligne in lignes) //Parcourir chaques lignes du csv
            {
                string[] colonnes = ligne.Split(';'); //Diviser chaque ligne en colonnes en utilisant le point-virgule comme d�limiteur

                if (colonnes.Length == 3) //Cette condition v�rifie si chaque ligne a le bon format, c'est-�-dire si elle contient trois colonnes : question, r�ponses et r�ponse correcte
                {
                    string question = colonnes[0];                  //Extraction de la question � partir de la premi�re colonne
                    string reponses = colonnes[1];                  //Extraction des r�ponses � partir de la deuxi�me colonne
                    int reponseCorrecte = int.Parse(colonnes[2]);   //Extraction de la r�ponse correcte � partir de la troisi�me colonne et conversion en entier

                    string[] optionsReponses = reponses.Split('/'); //cr�er un nouveau tableau de chaines qui s'appelle optionReponses dans lequel on va y mettre les dif�rentes reponses propos�es dans le csv qui sont s�par�es par /

                    Console.WriteLine($"Question : {question}");        //Afficher la question

                    for (int i = 0; i < optionsReponses.Length; i++)    //Pour chaques questions afficher les diff�rentes r�ponses
                    {
                        Console.WriteLine($"{i + 1}. {optionsReponses[i]}");
                    }

                    Console.Write("Votre r�ponse : ");                  //Afficher "Votre r�ponse : "

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
