using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    static class outils
    {
        public static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue, "ERREUR : Le nombre doit être supérieur à zéro");
        }
        public static int DemanderNombreEntre(string question, int min, int max, string messageErreurPersonnalise = null)
        {
            int nombre = DemanderNombre(question);

            if ((nombre >= min) && (nombre <= max))
            {
                return nombre;
            }

            if (messageErreurPersonnalise == null)
            {
                Console.WriteLine("ERREUR : Le nombre doit être compris entre " + min + " et " + max);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(messageErreurPersonnalise);
                Console.WriteLine();
            }

            return DemanderNombreEntre(question, min, max);
        }
        public static int DemanderNombre(string question)
        {
            while (true)
            {
                Console.Write(question);
                string reponseStr = Console.ReadLine();

                try
                {
                    int reponseInt = int.Parse(reponseStr);
                    return reponseInt;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Vous devez rentrer un nombre");
                    Console.WriteLine();
                }
            }
        }
    }
}
