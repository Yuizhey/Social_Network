using Persistence.Contexts;
using SocialNetwork.Application.Features.Events.Queries.GetAllEvents;
using SocialNetwork.Application.Interfaces.Repositories;
using SocialNetwork.Domain.Entities;

namespace Persistence.Repositories;

public class EventRepository : IEventRepository
{
    private readonly IGenericRepository<Event> repository;

    public EventRepository(IGenericRepository<Event> repository)
    {
        this.repository = repository;
    }
    
}