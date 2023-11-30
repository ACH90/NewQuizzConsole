public class GestionReponse
{
    public static void CorrigerReponse(int reponseCorrecte)
    {   
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


        
    }
}