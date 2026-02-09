using Template.Application.Records.Queries.GetRecordById;
using Template.TestTools.Records.Builders;

namespace AT.UnitTests.Records.Queries;

public class GetRecordByIdQueryHandlerTests
{
    private readonly GetRecordByIdQueryHandler _sut;

    public GetRecordByIdQueryHandlerTests()
    {
        _sut = new GetRecordByIdQueryHandlerBuilder().Build();
    }
}