

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

                if (colonnes.Length == 4) //Cette condition vérifie si chaque ligne a le bon format, c'est-à-dire si elle contient quatre colonnes : catégorie, question, réponses et réponse correcte
                {   
                    string categorie = colonnes[0];                    //Extraction de la catégorie à partir de la premiere colone
                    string question = colonnes[1];                  //Extraction de la question à partir de la deuxième colonne
                    string reponses = colonnes[2];                  //Extraction des réponses à partir de la troisième colonne
                    int reponseCorrecte = int.Parse(colonnes[3]);   //Extraction de la réponse correcte à partir de la quatrieme colonne et conversion en entier

                    string[] optionsReponses = reponses.Split('/'); //créer un nouveau tableau de chaines qui s'appelle optionReponses dans lequel on va y mettre les diférentes reponses proposées dans le csv qui sont séparées par /

                    Console.WriteLine($@"Catégorie : {categorie}" + "\n");      //Afficher la catégorie
                    Console.WriteLine($"Question : {question}" + "\n");        //Afficher la question

                    //for (int i = 0; i < optionsReponses.Length; i++)    //Pour chaques questionsn, tant que reponse est 1,2 ou 3 afficher les différentes réponses
                    //{
                    //    Console.WriteLine($"{i + 1}. {optionsReponses[i]}");
                    //}


                    int i = 1; // Initialisation du compteur pour afficher les options
                    foreach (var option in optionsReponses)
                    {
                 
                        Console.WriteLine($"{i}. {option}"); // Afficher chaque option avec son numéro
                       
                        i++;
                    }
                    int reponseUtilisateur = int.Parse(Console.ReadLine());          //Lecture de la réponse de l'utilisateur et conversion en entier
                    if (reponseUtilisateur == 1 || reponseUtilisateur == 2 || reponseUtilisateur == 3)
                    {
                        if (reponseUtilisateur == reponseCorrecte)          //Si reponse utilisateur == reponse correcte afficher "Correct!"
                        {
                            Console.WriteLine("Correct !\n");
                        }
                        else                                               // Sinon afficher $"Incorrect.La réponse correcte est : { reponseCorrecte}\n"
                        {
                            Console.WriteLine($"Incorrect. La réponse correcte est : {reponseCorrecte}\n");
                        }

                    }
                    else
                    {
                        // Le code à exécuter si la réponse utilisateur n'est pas égale à 1, 2 ou 3
                        Console.WriteLine($@"La réponse utilisateur n'est pas 1, 2 ou 3." + "\n");
                    }
                    // Autres actions si nécessaire


                    Console.Write("Votre réponse : ");                  //Afficher "Votre réponse : "



                    //GestionReponse.CorrigerReponse(reponseCorrecte);
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
