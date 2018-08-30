using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // espace de nom pour l'utilisation de liste sous forme de fichier si besoin


namespace BoVoyage2
{
    class Program
    {
        static void Main(string[] args) // creation du Menu d'entrée dans le systeme avec acces par mdp
        {
          Classes.Menus.PageAccueil();

            Console.WriteLine("\nVotre identifiant qui est votre prenom, je vous pries (Alex)");
            var name = Console.ReadLine();
            var date = DateTime.Now;

            if (name != "Alex") //une liste de commercial par exemple
            {
                Console.WriteLine("\n\aVous n'avez pas acces, désolé !");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"\nBienvenu {name}, veuillez entrez inscrir votre mot de passe");
                var mdp = Console.ReadLine();
                if (mdp == "UserCom")//liste de mdp egalement...
                Console.WriteLine($"\n\nQue souhaitez vous réaliser aujourd'hui {name}?\n");

            bool continuer = true;
            while (continuer)
                 {
                var mGesCial = Classes.Menus.MenuGestionCommerciale();
                switch (mGesCial)
                {
                    case "1":
                        Classes.Menus.MenuGestionVoyages();
                        break;

                    case "2":
                        Classes.Menus.MenuGestionClients();
                        break;

                    case "q":
                    case "Q":
                        continuer = false;
                        break;

                    default:
                        Classes.Esthetisme.MiseEnFormeTexte("Choix invalide, l'application va fermer", ConsoleColor.Red, centre: false);

                        continuer = false;
                        break;
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
