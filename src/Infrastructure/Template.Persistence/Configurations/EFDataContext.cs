
using Microsoft.EntityFrameworkCore;

namespace Template.Persistence.Configurations;

public class EFDataContext(
    DbContextOptions<EFDataContext> options)
    : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EFDataContext).Assembly);
    }
}