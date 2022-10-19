using InitialTry.Application.Responses;
using MediatR;
using System.Collections.Generic;

namespace InitialTry.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventsListQuery: IRequest<Response<IEnumerable<EventListVm>>>
    {

    }
}
