using AT.Application.Abstractions.Handlers;
using AT.Application.Records.Commands.CreateRecord;
using AT.TestTools.Records.Builders;

namespace AT.UnitTests.Records.Commands;

public class CreateRecordCommandHandlerTests
{
    private readonly ICommandHandler<CreateRecordCommand, string> _sut;

    public CreateRecordCommandHandlerTests()
    {
        _sut = new CreateRecordCommandHandlerBuilder().Build();
    }
}