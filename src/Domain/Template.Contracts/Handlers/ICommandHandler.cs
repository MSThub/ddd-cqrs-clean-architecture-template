namespace Template.Application.Abstractions.Handlers;

public interface ICommandHandler<TCommand, TResult>
{
    TResult Handle(TCommand command);
}