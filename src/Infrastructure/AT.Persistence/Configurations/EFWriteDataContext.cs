using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AT.Persistence.Configurations;

public class EFWriteDataContext : EFDataContext
{
    public EFWriteDataContext(
        DbContextOptions<EFDataContext> options)
        : base(options)
    {
    }

    public EFWriteDataContext(
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
        tracker.AutoDetectChangesEnabled = true;
        tracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
        return tracker;
    }
}