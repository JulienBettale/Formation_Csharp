using System;

namespace nombre_magique
{
    class Program
    {
        /* 
         * Fonction DemanderChiffre : Demande un chiffre à l'utilisateur
         * Ce chiffre doit être compris entre 0 et 10
         */
        static int DemanderChiffre(int min, int max)
        {
            int chiffreUtilisateur = min - 1;

            while ((chiffreUtilisateur < min) || (chiffreUtilisateur > max))
            {
                Console.Write("Choissiez un nombre entre " + min + " et " + max + " : ");
                string chiffreStr = Console.ReadLine();

                try
                {
                    chiffreUtilisateur = int.Parse(chiffreStr);

                    if ((chiffreUtilisateur < min) || (chiffreUtilisateur > max))
                    {
                        Console.WriteLine("ERREUR : Le chiffre doit être entre " + min + " et " + max);
                    }
                }
                catch
                {
                    Console.WriteLine("ERREUR : Chiffre invalide");
                }
            }
            return chiffreUtilisateur;
        }

        /* 
         * Fonction AfficherReponse : Récupère le chiffre de l'utilisation + le chiffre magique
         * Boucle tant que le chiffre de l'utilisateur et le chiffre magique ne sont égaux
         */
        static void AfficherReponse(int min, int max, int chiffreMagique, int vie)
        {

            int chiffre = min - 1;

            //while ((chiffre != chiffreMagique) && (vie != 0))
            for(; vie > 0; vie--)
            {
                Console.WriteLine("Il vous reste " + vie + " essais");
                chiffre = DemanderChiffre(min, max);

                if (chiffre < chiffreMagique)
                {
                    Console.WriteLine("Le chiffre magique est plus grand !");
                    Console.WriteLine();
                    
                }
                else if (chiffre > chiffreMagique)
                {
                    Console.WriteLine("Le chiffre magique est plus petit !");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Félicitation vous avez gagné !!");
                    break;
                }
            }

            if (chiffre != chiffreMagique)
            {
                Console.WriteLine();
                Console.WriteLine("Vous avez perdu !");
                Console.WriteLine("Le chiffre magique était " + chiffreMagique);
            }
            
        }

        static void Main(string[] args)
        {
            Random rand = new Random();

            const int CHIFFRE_MIN = 0;
            const int CHIFFRE_MAX = 10;
            const int NB_VIE = 5;

            int chiffreMagique = rand.Next(CHIFFRE_MIN, CHIFFRE_MAX + 1);

            // Appelle de la fonction AfficherReponse
            AfficherReponse(CHIFFRE_MIN, CHIFFRE_MAX, chiffreMagique, NB_VIE);
        }
    }
}
