using System;
// namespace BoVoyageQuiMarche

public class ServiceVoyage
{
            public void VosVoyages(VosVoyages vosVoyages)
            {
                using (var contexte = new Contexte())
                {
                    contexte.Id.Add(vosVoyages); // je pense qu'il faut adapter au formul sql
                    contexte.SaveChanges();
                }
            }
            public void Destination(Destination destination) // ajouter le namespace DAL
            {
                using (var contexte = new Contexte())
                {
                    contexte.Entry(destination).State = EntityState.Deleted;
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
                    return contexte.IdDestination
                        .Select(Pays => Pays.adapter)//a valider
                        .OrderBy(Continent => Continent.Afrique).ToList();// adapter le pays si necessaire
                }
            }
            public Destination GetDestination(int idDestination)
            {
                using (var contexte = new Contexte())
                {
                    return contexte.Destination
                        .Include(x => x.adapter)// adapter toujours...
                        .Single(x => x.Id == idDestination); // pareil...
                }
            }
        
}