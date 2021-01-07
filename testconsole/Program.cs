/**
 * Jeu du nombre caché
 * author : Emds
 * date : 28/12/2020
 */
using System;


namespace testconsole
{
    class Program
    {
        
        static int saisie(string message, int borneMin, int borneMax)
        {
            
            int nombre = 0;
           bool correct = false;

            while (!correct || nombre <  borneMin || nombre > borneMax)
            {
                try
                {
                    Console.Write(message + "(entre " + borneMin +" et " + borneMax + ")  = ");
                    nombre = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                }
            }
            return nombre;
        }
        static void Main(string[] args)
        {
            // déclaration
            int min = 1, max = 100;
            int valeur = 0, essai = 0, nbre = 1;
            bool correct = false;
            // saisie du nombre à chercher
            while (!correct)
            {
                try
                {
                    Console.Write("Entrez le nombre à chercher = ");
                    valeur = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                }
            }
            Console.Clear();

            // saisie du premier essai
           essai = saisie("Entrez un essai", min, max);
            // boucle sur les essais
            while (essai != valeur)
            {

                // test de l'essai par rapport à la valeur à chercher
                if (essai > valeur)
                {
                    Console.WriteLine("--> trop grand!");
                }
                else
                {
                    Console.WriteLine("--> trop petit!");
                }
                // saisi d'un nouvel essai
                correct = false;
                while (!correct)
                {
                    try
                    {
                        Console.Write("Entrez un essai =", min, max);
                        essai = int.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch
                    {
                        Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                    }
                }// compteur d'essais
                nbre++;



            } // valeur trouvée
            Console.WriteLine("vous avez trouvé en " + nbre + " de fois !");
            Console.ReadLine();





        }
    }
}

