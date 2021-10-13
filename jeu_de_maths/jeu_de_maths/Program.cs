using System;

namespace jeu_de_maths
{
    class Program
    {
        enum e_Operateur
        {
            ADDITION = 1,
            SOUSTRACTION = 2,
            MULTIPLICATION = 3
        }
        static void AfficherReponse()
        {

        }
        static bool PoserQuestion(int min, int max)
        {
            Random rand = new Random();

            int reponseInt = 0;

            while (true)
            {
                int chiffreUn = rand.Next(min, max);
                int chiffreDeux = rand.Next(min, max);
                e_Operateur operateur = (e_Operateur)rand.Next(1, 4);
                int resultatAttendu;

                switch (operateur)
                {
                    case e_Operateur.ADDITION:
                        Console.Write(chiffreUn + " + " + chiffreDeux + " = ");
                        resultatAttendu = chiffreUn + chiffreDeux;
                        break;
                    case e_Operateur.SOUSTRACTION:
                        Console.Write(chiffreUn + " - " + chiffreDeux + " = ");
                        resultatAttendu = chiffreUn - chiffreDeux;
                        break;
                    case e_Operateur.MULTIPLICATION:
                        Console.Write(chiffreUn + " x " + chiffreDeux + " = ");
                        resultatAttendu = chiffreUn * chiffreDeux;
                        break;
                    default:
                        // Cas inconnu
                        Console.WriteLine("ERREUR : opérateur inconnu !");
                        return false;
                }

                string reponseStr = Console.ReadLine();

                try
                {
                    reponseInt = int.Parse(reponseStr);

                    if (reponseInt != resultatAttendu)
                    {
                        return false;
                    }
                    return true;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Entrez un chiffre valide !!");
                }
            }
        }
        static void Main(string[] args)
        {
            const int CHIFFRE_MIN = 1;
            const int CHIFFRE_MAX = 10;
            const int NB_QUESTION = 5;

            int points = 0;
            int moyenne = NB_QUESTION / 2;

            for(int i = 0; i < NB_QUESTION; i++)
            {
                Console.WriteLine("Question n°" + (i + 1) + "/" + NB_QUESTION);

                bool reponse = PoserQuestion(CHIFFRE_MIN, CHIFFRE_MAX);

                if (reponse)
                {
                    Console.WriteLine("Bonne réponse !");
                    points++;
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse !");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Nombre de points : " + points + "/" + NB_QUESTION);

            if (points == NB_QUESTION)
            {
                Console.WriteLine("Excellent !");
            }
            else if (points == 0)
            {
                Console.WriteLine("Révisez vos maths !");
            }
            else if (points > moyenne)
            {
                Console.WriteLine("Pas mal !");
            }
            else
            {
                Console.WriteLine("Peut mieux faire !");
            }
        }
    }
}
