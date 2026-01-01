using AT.Application.Records.Queries.GetRecordById;
using AT.TestTools.Records.Builders;

namespace AT.UnitTests.Records.Queries;

public class GetRecordByIdQueryHandlerTests
{
    private readonly GetRecordByIdQueryHandler _sut;

    public GetRecordByIdQueryHandlerTests()
    {
        _sut = new GetRecordByIdQueryHandlerBuilder().Build();
    }
}