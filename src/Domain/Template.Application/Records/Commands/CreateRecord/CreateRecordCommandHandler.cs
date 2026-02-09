using Template.Contracts.Persistence;
using Template.Application.Abstractions.Handlers;
using Template.Application.Abstractions.Persistence.Records;

namespace Template.Application.Records.Commands.CreateRecord;

public class CreateRecordCommandHandler(
    IRecordRepository repository,
    IUnitOfWork unitOfWork) : ICommandHandler<CreateRecordCommand, string>
{
    public string Handle(CreateRecordCommand command)
    {
        return "Method Executed";
    }
}