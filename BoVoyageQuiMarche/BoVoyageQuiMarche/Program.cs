using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageQuiMarche
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuer = true;
            while (continuer)
            {
                var choixMenuPrincipal = MenuPrincipal();
                switch (choixMenuPrincipal)
                {
                    case "1":
                        bool continuer2 = true;
                        Console.Clear();
                        while (continuer2)
                        {

                            var choixMenuVoyage = MenuVoyage();
                            switch (choixMenuVoyage)
                            {
                                case "1":

                                    //ListeOffresA();
                                    break;
                                case "2":
                                    break;
                                case "3":
                                    break;
                                case "4":
                                    continuer2 = false;
                                    break;
                            }
                        }
                        break;
                    case "2":
                        bool continuer3 = true;
                        Console.Clear();
                        while (continuer3)
                        {

                            var choixMenuClient = MenuClient();
                            switch (choixMenuClient)
                            {
                                case "1":
                                    //ListeOffres();
                                    break;
                                case "2":
                                    break;
                                case "3":
                                    break;
                                case "4":
                                    continuer3 = false;
                                    break;
                            }
                        }
                        break;
                    case "3":
                        continuer = false;
                        break;
                    default:
                        Console.WriteLine("Choix invalide, veuiller recommencer");
                        Console.ReadKey();
                        //continuer = true;
                        break;
                }
            }
        }
        static string MenuPrincipal()
        {
            Console.Clear();

            Console.WriteLine("BoVoyage\n");
            Console.WriteLine("MENU PRINCIPAL\n");
            Console.WriteLine("1. Gestionnaire de voyage\n");
            Console.WriteLine("2. Gestionnaire clientèle\n");
            Console.WriteLine("3. Quitter BoVoyage");
            Console.Write("\nVotre choix : ");


            return Console.ReadLine();
        }
        static string MenuVoyage()
        {

            Console.WriteLine("Gestionnaire Voyage\n\n");
            Console.WriteLine("1. Liste des offres\n");
            Console.WriteLine("2. Ajouter une offre\n");
            Console.WriteLine("3. Supprimer une offre\n");
            Console.WriteLine("4. Retour");
            Console.Write("\nVotre choix : ");

            return Console.ReadLine();

        }
        static string MenuClient()
        {

            Console.WriteLine("Gestionnaire Clientèle\n\n");
            Console.WriteLine("1. Nouvelles reservations\n");
            Console.WriteLine("2. Liste Clients\n");
            Console.WriteLine("3. Campagne emailing\n");
            Console.WriteLine("4. Retour");

            return Console.ReadLine();
        }



    }
}
