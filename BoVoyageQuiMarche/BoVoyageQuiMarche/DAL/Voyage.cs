namespace BoVoyageQuiMarche
{
    public class Voyage
    {
        public void Id(Id id)
        {
            using (var contexte = new Contexte())
            {
                contexte.Id.Add(id);
                contexte.SaveChanges();
            }
        }

        public void DateAller(DateAller dateAller) // ajouter le namespace DAL
        {
            using (var contexte = new Contexte())
            {
                contexte.Entry(dateAller).State = EntityState.Deleted;
                contexte.SaveChanges();
            }
        }

        public void DateRetour(DateRetour dateRetour)
        {
            using (var contexte = new Contexte())
            {
                contexte.Pays.DateRetour(dateRetour);
                contexte.Entry(dateRetour).State = EntityState.Modified;
                contexte.SaveChanges();
            }
        }

        public void PlacesDisponibles(PlacesDisponibles placesDisponibles)
        {
            using (var contexte = new Contexte())
            {
                contexte.PlacesDisponibles.Add(placesDisponibles);
                contexte.SaveChanges();
            }
        }
         public void PrixParPersonne(PrixParPersonne prixParPersonne)
        {
            using (var contexte = new Contexte())
            {
                contexte.PrixParPersonne.Add(prixParPersonne);
                contexte.SaveChanges();
            }
        }
         public void IdAgenceVoyage(IdAgenceVoyage idAgenceVoyage) // verif si nommage correct
        {
            using (var contexte = new Contexte())
            {
                contexte.IdAgenceVoyage.Add(idAgenceVoyage);
                contexte.SaveChanges();
            }
        }
        public IEnumerable<Destination> IdDestination()
        {
            using (var contexte = new Contexte())
            {
                return contexte.IdDestination // recup les bonnes info de la table
                    .Include(x => x.adapter)//adapter
                    .OrderBy(x => x.Nom).ToList();
            }
        }

        public Destination GetDestination(int idDestination)
        {
            using (var contexte = new Contexte())
            {
                return contexte.Destination
                    .Include(x => x.adapter)// adapter
                    .Single(x => x.Id == idDestination);
            }
        }
    }
}
