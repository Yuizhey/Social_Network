using MediatR;
using SocialNetwork.Application.Interfaces.Repositories;
using SocialNetwork.Domain.Entities;
using SocialNetwork.Domain.Enums;

namespace SocialNetwork.Application.Features.Events.Queries.GetAllEvents;

public class GetAllEventsQueryHandler : IRequestHandler<GetAllEventsQuery, IEnumerable<GetAllEventsDto>>
{
    private readonly IEventRepository repository;

    public GetAllEventsQueryHandler(IEventRepository repository)
    {
        this.repository = repository;
    }
    
    public async Task<IEnumerable<GetAllEventsDto>> Handle(GetAllEventsQuery request, CancellationToken cancellationToken)
    {
        var format = (EventType)Enum.Parse(typeof(EventType), request.formatType.ToUpper(), ignoreCase: true);
        var data = await repository.GetAllEventsWithFormatFilter(format);
        
        var result = data.Select(e => new GetAllEventsDto
        {
            Id = e.Id,
            Title = e.Title,
            Author = e.Author,
            InterestedCount = e.InterestedCount,
            GoingCount = e.GoingCount,
            EventDate = e.EventDate,
        });
        
        return result ?? new List<GetAllEventsDto>();
    }
}