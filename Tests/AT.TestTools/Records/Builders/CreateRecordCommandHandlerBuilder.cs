using AT.Application.Abstractions.Persistence;
using AT.Application.Records.Commands.CreateRecord;
using AT.Domain.Records.Repositories;
using Moq;

namespace AT.TestTools.Records.Builders;

public class CreateRecordCommandHandlerBuilder
{
    private Mock<IRecordRepository> _repositoryMock =
        new();

    private Mock<IUnitOfWork> _unitOfWorkMock =
        new();

    public CreateRecordCommandHandlerBuilder WithRepository(
        Mock<IRecordRepository> repositoryMock)
    {
        _repositoryMock = repositoryMock;
        return this;
    }

    public CreateRecordCommandHandlerBuilder WithUnitOfWork(
        Mock<IUnitOfWork> unitOfWorkMock)
    {
        _unitOfWorkMock = unitOfWorkMock;
        return this;
    }

    public CreateRecordCommandHandler Build()
    {
        return new CreateRecordCommandHandler(
            _repositoryMock.Object,
            _unitOfWorkMock.Object);
    }
}