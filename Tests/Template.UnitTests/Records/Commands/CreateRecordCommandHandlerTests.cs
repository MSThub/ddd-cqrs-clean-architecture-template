using Template.Application.Abstractions.Handlers;
using Template.Application.Records.Commands.CreateRecord;
using Template.TestTools.Records.Builders;

namespace AT.UnitTests.Records.Commands;

public class CreateRecordCommandHandlerTests
{
    private readonly ICommandHandler<CreateRecordCommand, string> _sut;

    public CreateRecordCommandHandlerTests()
    {
        _sut = new CreateRecordCommandHandlerBuilder().Build();
    }
}