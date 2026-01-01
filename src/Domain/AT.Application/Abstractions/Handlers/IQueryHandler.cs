namespace AT.Application.Abstractions.Handlers;

public interface IQueryHandler<TQuery, TResult>
{
    TResult Handle(TQuery query);
}
