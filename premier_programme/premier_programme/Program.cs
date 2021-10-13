using System;

namespace premier_programme
{
    class Program
    {
        // Fonction DemanderNbPersonne, demande le nombre de personne
        static int DemanderNbPersonne()
        {
            int nbPersonneNum = 0;
            
            while (nbPersonneNum <= 0)
            {
                Console.Write("Combien êtes vous ? ");
                string nbPersonneStr = Console.ReadLine();

                try
                {
                    nbPersonneNum = int.Parse(nbPersonneStr);

                    if (nbPersonneNum < 0)
                    {
                        Console.WriteLine("ERROR : Le nombre de personne ne doit pas être négatif");
                    }
                    if (nbPersonneNum == 0)
                    {
                        Console.WriteLine("ERROR : Le nombre doit être suppérieur à 0");
                    }
                }
                catch
                {
                    Console.WriteLine("ERROR : Entrez un nombre valide");
                }
            }
            return nbPersonneNum;
            
        }
        // Fonction DemanderNom, demande le nom de l'utilisateur
        static string DemanderNom()
        {
            string nom = "";

            while (nom == "")
            {
                Console.Write("Quel est votre nom ? ");
                nom = Console.ReadLine();
                nom = nom.Trim();

                if (nom == "")
                {
                    Console.WriteLine("ERROR : ");
                }
            }
            return nom;
        }

        // Fonction DemandeAge, demande l'age de l'utilisateur
        static int DemanderAge()
        {
            int ageNum = 0;
            
            while (ageNum <= 0)
            {
                Console.Write("Quel est votre age ? ");
                string ageStr = Console.ReadLine();

                try
                {
                    ageNum = int.Parse(ageStr);

                    if (ageNum < 0)
                    {
                        Console.WriteLine("ERROR : L'age ne doit pas être négatif");
                    }
                    if (ageNum == 0)
                    {
                        Console.WriteLine("ERROR : L'age doit être suppérieur à 0");
                    }
                }
                catch
                {
                    Console.WriteLine("ERROR : Entrez un age valide");
                }
            }
            return ageNum;
        }

        // Fonction AfficherInfos, récupère et affiche les informations demandé ci-dessus
        static void AfficherInfos(string nom, int age)
        {
            Console.WriteLine();
            Console.WriteLine("Bonjour " + nom + ".");
            Console.WriteLine("Vous avez " + age + " ans.");
            Console.WriteLine("L'an prochain vous aurez " + (age + 1) + " ans.");

            if (age < 10)
            {
                Console.WriteLine("Vous êtes un enfant");
            }
            else if (age == 18)
            {
                Console.WriteLine("Vous êtes tout juste majeur");
            }
            else if (age == 17)
            {
                Console.WriteLine("Vous serez bientôt majeur");
            }
            else if (age >= 60)
            {
                Console.WriteLine("Vous êtes sénior");
            }
            else if (age >= 18)
            {
                Console.WriteLine("Vous êtes majeur !!");
            }
            else
            {
                Console.WriteLine("Vous êtes mineur !");
            }
        }
        static void Main(string[] args)
        {
            // Appel de la fonction "DemanderNbPersonne"
            int nbPersonne = DemanderNbPersonne();

            for (int i = 0; i < nbPersonne; i++)
            {
                // Appel de la fonction "DemanderNom"
                string nom = DemanderNom();
                // Appel de la fonction "DemanderAge"
                int ageNum = DemanderAge();
                // Appel de la fonction "AfficherInfos"
                AfficherInfos(nom, ageNum);
                Console.WriteLine();
                Console.WriteLine("-----");
            }
        }
    }
}
