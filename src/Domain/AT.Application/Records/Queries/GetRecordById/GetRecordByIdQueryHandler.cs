using AT.Application.Abstractions.Handlers;
using AT.Domain.Records.Repositories;

namespace AT.Application.Records.Queries.GetRecordById;

public class GetRecordByIdQueryHandler(IRecordQuery query) : IQueryHandler<GetRecordByIdQuery, RecordDto>
{
    public RecordDto Handle(GetRecordByIdQuery query)
    {
        return new RecordDto
        {
            RecordName = "Temp Record"
        };
    }
}