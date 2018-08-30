namespace BoVoyageQuiMarche
{
    public class AgenceDeVoyage
    {
        public void Id(Id id)
        {
            using (var contexte = new Contexte())
            {
                contexte.Id.Add(id);
                contexte.SaveChanges();
            }
        }

        public void Nom(Nom nom) // ajouter le namespace DAL
        {
            using (var contexte = new Contexte())
            {
                contexte.Entry(nom).State = EntityState.Deleted;
                contexte.SaveChanges();
            }
        }

        public IEnumerable<Id> ListerId()
        {
            using (var contexte = new Contexte())
            {
                return contexte.Id // recup les bonnes info de la table
                    .Include(x => x.adapter)//adapter
                    .OrderBy(x => x.Nom).ToList();
            }
        }

        public Id GetDestination(int idId)
        {
            using (var contexte = new Contexte())
            {
                return contexte.Id
                    .Include(x => x.adapter)// adapter
                    .Single(x => x.Id == idId);
            }
        }
    }
}
