using Microsoft.EntityFrameworkCore;

namespace TripLogger.Models
{
    public class TripLoggerContext : DbContext
    {
        public TripLoggerContext(DbContextOptions<TripLoggerContext> options)
            : base(options)
        { }

        public DbSet<Trip> Trips { get; set; }

    }
}
