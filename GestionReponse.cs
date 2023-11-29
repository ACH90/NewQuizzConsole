public class GestionReponse
{
    public static void CorrigerReponse(int reponseCorrecte)
    {
        int reponseUtilisateur = int.Parse(Console.ReadLine());          //Lecture de la réponse de l'utilisateur et conversion en entier

        if (reponseUtilisateur == reponseCorrecte)          //Si reponse utilisateur == reponse correcte afficher "Correct!"
        {
            Console.WriteLine("Correct !\n");
        }
        else                                               // Sinon afficher $"Incorrect.La réponse correcte est : { reponseCorrecte}\n"
        {
            Console.WriteLine($"Incorrect. La réponse correcte est : {reponseCorrecte}\n");
        }
    }
}