using Microsoft.EntityFrameworkCore;

namespace TripLogger.Models
{
    public class TripLoggerContext : DbContext
    {
        public TripLoggerContext(DbContextOptions<TripLoggerContext> options)
            : base(options)
        { }

        public DbSet<Trip> Trips { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Accommodation> Accommodations { get; set; }
        public DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TripConfig());
            modelBuilder.ApplyConfiguration(new TripActivityConfig());
        }

    }
}
