using AT.Application.Records.Queries.GetRecordById;
using AT.Domain.Records.Repositories;
using Moq;

namespace AT.TestTools.Records.Builders;

public sealed class GetRecordByIdQueryHandlerBuilder
{
    private Mock<IRecordQuery> _recordQueryMock = new();

    public GetRecordByIdQueryHandlerBuilder WithRecordQuery(
        Mock<IRecordQuery> recordQueryMock)
    {
        _recordQueryMock = recordQueryMock;
        return this;
    }

    public GetRecordByIdQueryHandler Build()
    {
        return new GetRecordByIdQueryHandler(
            _recordQueryMock.Object);
    }
}