

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

                if (colonnes.Length == 4) //Cette condition v�rifie si chaque ligne a le bon format, c'est-�-dire si elle contient quatre colonnes : cat�gorie, question, r�ponses et r�ponse correcte
                {   
                    string categorie = colonnes[0];                    //Extraction de la cat�gorie � partir de la premiere colone
                    string question = colonnes[1];                  //Extraction de la question � partir de la deuxi�me colonne
                    string reponses = colonnes[2];                  //Extraction des r�ponses � partir de la troisi�me colonne
                    int reponseCorrecte = int.Parse(colonnes[3]);   //Extraction de la r�ponse correcte � partir de la quatrieme colonne et conversion en entier

                    string[] optionsReponses = reponses.Split('/'); //cr�er un nouveau tableau de chaines qui s'appelle optionReponses dans lequel on va y mettre les dif�rentes reponses propos�es dans le csv qui sont s�par�es par /

                    Console.WriteLine($@"Cat�gorie : {categorie}" + "\n");      //Afficher la cat�gorie
                    Console.WriteLine($"Question : {question}" + "\n");        //Afficher la question

                    //for (int i = 0; i < optionsReponses.Length; i++)    //Pour chaques questionsn, tant que reponse est 1,2 ou 3 afficher les diff�rentes r�ponses
                    //{
                    //    Console.WriteLine($"{i + 1}. {optionsReponses[i]}");
                    //}


                    int i = 1; // Initialisation du compteur pour afficher les options
                    foreach (var option in optionsReponses)
                    {
                 
                        Console.WriteLine($"{i}. {option}"); // Afficher chaque option avec son num�ro
                       
                        i++;
                    }
                    int reponseUtilisateur = int.Parse(Console.ReadLine());          //Lecture de la r�ponse de l'utilisateur et conversion en entier
                    if (reponseUtilisateur == 1 || reponseUtilisateur == 2 || reponseUtilisateur == 3)
                    {
                        if (reponseUtilisateur == reponseCorrecte)          //Si reponse utilisateur == reponse correcte afficher "Correct!"
                        {
                            Console.WriteLine("Correct !\n");
                        }
                        else                                               // Sinon afficher $"Incorrect.La r�ponse correcte est : { reponseCorrecte}\n"
                        {
                            Console.WriteLine($"Incorrect. La r�ponse correcte est : {reponseCorrecte}\n");
                        }

                    }
                    else
                    {
                        // Le code � ex�cuter si la r�ponse utilisateur n'est pas �gale � 1, 2 ou 3
                        Console.WriteLine($@"La r�ponse utilisateur n'est pas 1, 2 ou 3." + "\n");
                    }
                    // Autres actions si n�cessaire


                    Console.Write("Votre r�ponse : ");                  //Afficher "Votre r�ponse : "



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
