using AT.Application.Abstractions.Handlers;
using AT.Application.Abstractions.Persistence;
using AT.Domain.Records.Repositories;

namespace AT.Application.Records.Commands.CreateRecord;

public class CreateRecordCommandHandler(
    IRecordRepository repository,
    IUnitOfWork unitOfWork) : ICommandHandler<CreateRecordCommand, string>
{
    public string Handle(CreateRecordCommand command)
    {
        return "Method Executed";
    }
}