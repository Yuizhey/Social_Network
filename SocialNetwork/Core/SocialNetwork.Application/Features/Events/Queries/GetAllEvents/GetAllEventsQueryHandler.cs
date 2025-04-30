using MediatR;
using SocialNetwork.Application.Interfaces.Repositories;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Application.Features.Events.Queries.GetAllEvents;

public class GetAllEventsQueryHandler : IRequestHandler<GetAllEventsQuery, IEnumerable<GetAllEventsDto>>
{
    private readonly IGenericRepository<Event> repository;

    public GetAllEventsQueryHandler(IGenericRepository<Event> repository)
    {
        this.repository = repository;
    }
    
    public async Task<IEnumerable<GetAllEventsDto>> Handle(GetAllEventsQuery request, CancellationToken cancellationToken)
    {
        var data = await repository.GetAllAsync();
        
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