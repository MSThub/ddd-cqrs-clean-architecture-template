using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Template.Persistence.Configurations;

public class EFReadDataContext : EFDataContext
{
    public EFReadDataContext(
        DbContextOptions<EFDataContext> options)
        : base(options)
    {
    }

    public EFReadDataContext(
        string connectionString)
        : base(
            new DbContextOptionsBuilder<EFDataContext>()
                .UseSqlServer(connectionString)
                .Options)
    {
    }

    public override ChangeTracker ChangeTracker =>
        ConfigureChangeTracker(base.ChangeTracker);

    private static ChangeTracker ConfigureChangeTracker(ChangeTracker tracker)
    {
        tracker.LazyLoadingEnabled = false;
        tracker.AutoDetectChangesEnabled = false;
        tracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        return tracker;
    }
}