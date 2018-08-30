using System.Data.Entity;
namespace BoVoyageQuiMarche
{
    internal class Contexte : DbContext
    {
        public DbSet<DossierReservation> DossiersReservations { get; set; }

        public DbSet<AgenceVoyage> AgencesVoyages { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Destination> Destinations { get; set; }

        public DbSet<Participant> Participants { get; set; }
        
        public DbSet<Voyage> Voyages { get; set; }
    }
}
