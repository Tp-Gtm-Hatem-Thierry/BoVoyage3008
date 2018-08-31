using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BoVoyageQuiMarche.Services
{
    class ServiceReservation
    {
        public void SupprimerDossierReservation(DossierReservation dossier)
        {
            using (var contexte = new Contexte())
            {
                contexte.Entry(dossier).State = EntityState.Deleted;
                contexte.SaveChanges();
            }
        }
        public DossierReservation GetDossier(int idDossier)
        {
            using (var contexte = new Contexte())
            {
                return contexte.DossiersReservations.Single(x => x.Id == idDossier);
                    //.Include(x => x.Modeles)
                    //.Single(x => x.Id == idMarque);
            }
        }
    }

}
