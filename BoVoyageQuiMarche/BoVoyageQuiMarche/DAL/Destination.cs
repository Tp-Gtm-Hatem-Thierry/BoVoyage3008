namespace BoVoyageQuiMarche
{
    public class Destination
    {
        public void Id(Id id)
        {  
            //var date = DateTime.Now; // Affichage de la date
            using (var contexte = new Contexte())
            {
                contexte.Id.Add(id);
                contexte.SaveChanges();
            }
        }

        public void Continent(Continent continent) // ajouter le namespace DAL
        {
            using (var contexte = new Contexte())
            {
                contexte.Entry(continent).State = EntityState.Deleted;
                contexte.SaveChanges();
            }
        }

        public void Pays(Pays pays)
        {
            using (var contexte = new Contexte())
            {
                contexte.Pays.Attach(pays);
                contexte.Entry(pays).State = EntityState.Modified;
                contexte.SaveChanges();
            }
        }

        public void Region(Region region)
        {
            using (var contexte = new Contexte())
            {
                contexte.Region.Add(region);
                contexte.SaveChanges();
            }
        }

        public IEnumerable<Destination> ListerDestination()
        {
            using (var contexte = new Contexte())
            {
                return contexte.Destination // recup les bonnes info de la table
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
