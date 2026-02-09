using Template.Application.Abstractions.Persistence.Records;
using Template.Contracts.Persistence;
using Template.Persistence.Configurations;

namespace Template.Persistence.Records;

public class RecordQuery(EFReadDataContext context)
    : IRecordQuery
{
    
}