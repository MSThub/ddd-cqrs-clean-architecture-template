using AT.Application.Abstractions.Persistence;
using AT.Domain.Records.Repositories;
using AT.Persistence.Configurations;

namespace AT.Persistence.Records;

public class RecordQuery(EFReadDataContext context)
    : IRecordQuery , IQuery
{
    
}