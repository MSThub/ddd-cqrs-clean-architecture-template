using AT.Application.Abstractions.Handlers;
using AT.Application.Records.Commands.CreateRecord;
using AT.Application.Records.Queries.GetRecordById;
using Microsoft.AspNetCore.Mvc;

namespace AT.RestAPI.Controllers.Records;

[ApiController]
[Route("api/v1/records")]
public class RecordsController(
    ICommandHandler<CreateRecordCommand, string> createRecordCommandHandler,
    ICommandHandler<GetRecordByIdQuery, RecordDto> getRecordByIdQueryHandler) : ControllerBase
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