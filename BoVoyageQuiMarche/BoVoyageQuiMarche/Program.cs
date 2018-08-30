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

            Console.WriteLine("BoVoyage\n");
            Console.WriteLine("MENU PRINCIPAL\n");
            Console.WriteLine("1. Nos listes de Voyages\n");
            Console.WriteLine("2. Nos listes Clients\n");
            Console.WriteLine("3. Quitter BoVoyage");
            Console.Write("\nVotre choix : ");


            return Console.ReadLine();
        }
        static string MenuVoyage()
        {

            Console.WriteLine("Gestion de nos offres voyage\n\n");
            Console.WriteLine("1. Liste de nos offres\n");
            Console.WriteLine("2. Ajouter une offre\n");
            Console.WriteLine("3. Supprimer une offre\n");
            Console.WriteLine("4. Retour");
            Console.Write("\nVotre choix : ");

            return Console.ReadLine();

        }
        static string MenuClient()
        {

            Console.WriteLine("Gestion de nos clients\n\n");
            Console.WriteLine("1. Nouvelles reservations\n");
            Console.WriteLine("2. Liste de nos Clients\n");
            Console.WriteLine("3. Campagne emailing\n");
            Console.WriteLine("4. Retour");

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
