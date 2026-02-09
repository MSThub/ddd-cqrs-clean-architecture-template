using Template.Application.Abstractions.Handlers;
using Template.Application.Abstractions.Persistence.Records;

namespace Template.Application.Records.Queries.GetRecordById;

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