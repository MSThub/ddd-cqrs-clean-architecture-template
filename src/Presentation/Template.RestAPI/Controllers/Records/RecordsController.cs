using Microsoft.AspNetCore.Mvc;
using Template.Application.Abstractions.Handlers;
using Template.Application.Records.Commands.CreateRecord;
using Template.Application.Records.Queries.GetRecordById;

namespace Template.RestAPI.Controllers.Records;

[ApiController]
[Route("api/v1/records")]
public class RecordsController(
    ICommandHandler<CreateRecordCommand, string> createRecordCommandHandler,
    IQueryHandler<GetRecordByIdQuery, RecordDto> getRecordByIdQueryHandler) : ControllerBase
// i wanted to keep it simple so I didn't use IMediatR or sth else
{
    [HttpPost]
    public string CreateRecord([FromBody] CreateRecordCommand command)
    {
        return createRecordCommandHandler.Handle(command);
    }

    [HttpGet("{id}")]
    public RecordDto GetRecordById([FromRoute] string id)
    {
        return getRecordByIdQueryHandler.Handle(
            new GetRecordByIdQuery{Id = id});
    }
    
}