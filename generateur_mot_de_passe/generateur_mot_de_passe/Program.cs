using System;
using FormationCS;

namespace generateur_mot_de_passe
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NB_MOT_DE_PASSE = 10;

            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string majuscules = minuscules.ToUpper();
            string chiffre = "0123456789";
            string caractereSpeciaux = "?./§,;!ù*$^&~#{[@]}";
           
            string alphabet;

            Random rand = new Random();

            int longueurMotDePasse = outils.DemanderNombrePositifNonNul("Longueur du mot de passe : ");
            Console.WriteLine();
            int typeMotDePasse = outils.DemanderNombreEntre("Vous voulez un mor de passe avec : \n" +
                "1 - Uniquement avec des caractères en minuscule\n" +
                "2 - Des caractères minuscules et majuscules\n" +
                "3 - Des caractères et des chiffres\n" +
                "4 - Des caractères, chiffres et caractères spéciaux\n" +
                "Votre choix : ", 1, 4);
            
            if (typeMotDePasse == 1)
                alphabet = minuscules;
            else if (typeMotDePasse == 2)
                alphabet = minuscules + majuscules;
            else if (typeMotDePasse == 3)
                alphabet = minuscules + majuscules + chiffre;
            else
                alphabet = minuscules + majuscules + chiffre+ caractereSpeciaux;

            int longueurAlphabet = alphabet.Length;

            for (int j = 0; j < NB_MOT_DE_PASSE; j++)
            {
                string motDePasse = "";
                for (int i = 0; i < longueurMotDePasse; i++)
                {
                    int index = rand.Next(0, longueurAlphabet);

                    motDePasse += alphabet[index];
                }
                Console.Write("Mot de passe : " + motDePasse + "\n");
            }
        }
    }
}
