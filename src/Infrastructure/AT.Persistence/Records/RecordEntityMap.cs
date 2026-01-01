using AT.Domain.Records.Aggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AT.Persistence.Records;

public class RecordEntityMap : IEntityTypeConfiguration<Record>
{
    public void Configure(EntityTypeBuilder<Record> builder)
    {
        throw new NotImplementedException();
    }
}