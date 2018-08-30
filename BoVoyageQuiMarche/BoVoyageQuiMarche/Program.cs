using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Entity;
using BoVoyageQuiMarche.Services;

namespace BoVoyageQuiMarche
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuer = true;
            while (continuer)
            {
               // var date = DateTime.Now; Ajout de la date
                var choixMenuPrincipal = MenuPrincipal();
                switch (choixMenuPrincipal)
                {
                    case "1":
                        bool continuer2 = true;
                        Console.Clear();
                        while (continuer2)
                        {

                            var choixMenuVoyage = MenuVoyage();
                            switch (choixMenuVoyage) // modification du nom des variables (choixMenu...)
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
                        break;
                }
            }
        }
        static string MenuPrincipal()
        {
            Console.Clear();
            {   // Pour le Fun § à intégrer si ca compile !
                //Console.WriteLine("\nVotre identifiant qui est votre prenom, je vous pries");
                //var name = Console.ReadLine();
                //var date = DateTime.Now;
                //    if (name != "Yannik")//une liste de commercial par exemple // Yannik
                //    {
                //       string administrateur = ("gtm@gmail.com");
                //       {
                //            Console.WriteLine($"\n\aVous n'êtes pas autoriser à acceder à notre site, veuillez vous rapprocher de votre administrateur, {administrateur} désolé !");
                //            Console.ReadKey();
                //        }
                //   }
                // else
                //{
                //    Console.WriteLine($"\nBienvenu {name}, veuillez entrez votre mot de passe");
                //    var mdp = Console.ReadLine();
                //    if (mdp == "N_i$a3")//liste de mdp egalement... // N_i$a3

            Console.WriteLine("BoVoyage\n");
            Console.WriteLine("MENU PRINCIPAL\n");
            Console.WriteLine(" 1. Nos listes de Voyages\n");
            Console.WriteLine(" 2. Nos listes Clients\n");
            Console.WriteLine(" 3. Quitter BoVoyage\n");
            Console.Write("\nQuel est vôtre choix ?\n");

            return Console.ReadLine();
        }
        static string MenuVoyage()
        {

            Console.WriteLine("vous ête sur la page : Gestion de nos offres voyage\n\n");
            Console.WriteLine(" 1. Liste de nos offres\n");
            Console.WriteLine(" 2. Ajouter une offre\n");
            Console.WriteLine(" 3. Supprimer une offre\n");
            Console.WriteLine(" 4. Retour\n");
            Console.Write("\nQuel est vôtre choix ?\n ");

            return Console.ReadLine();
        }
        static string MenuClient()
        {
            Console.WriteLine("vous ête sur la page : Gestion de nos clients\n\n");
            Console.WriteLine(" 1. Nouvelles reservations\n");
            Console.WriteLine(" 2. Liste de nos Clients\n");
            Console.WriteLine(" 3. Campagne emailing\n");
            Console.WriteLine(" 4. Retour\n");

            return Console.ReadLine();
        }
        private static void AfficherDossiersReservation()
        {
            Console.WriteLine();
            Console.WriteLine("> Dossiers :");

            var servicedossier = new ServiceReservation();//aporter correction**
            var dossier = serviceVoiture.ListerMarques();
            foreach (var marque in marques)
            {
                Console.Write($"{marque.Nom} ({marque.Id})");
                Console.WriteLine($" :{marque.Modeles.Count} modèle(s)");//*****
            }
        }

        private static void SupprimerReservation()
        {
            Console.WriteLine();
            Console.WriteLine(">SUPPRESSION D'UNE RESERVATION");

            DossierReservation dossier = ChoisirDossier();

            var serviceResa = new ServiceReservation();
            serviceResa.SupprimerDossierReservation(dossier);
        }

        private static DossierReservation ChoisirDossier()
        {
            Console.WriteLine("Choisissez votre numero de dossier");
            var idDossier = int.Parse(Console.ReadLine());

            var serviceReservation = new ServiceReservation();
            return serviceReservation.GetDossier(idDossier);
        }

    }
}
