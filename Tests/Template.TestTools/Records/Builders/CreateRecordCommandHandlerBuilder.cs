using Template.Application.Records.Commands.CreateRecord;
using Moq;
using Template.Application.Abstractions.Persistence.Records;
using Template.Contracts.Persistence;

namespace Template.TestTools.Records.Builders;

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