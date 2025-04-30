using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using SocialNetwork.Application.Features.Events.Queries.GetAllEvents;
using SocialNetwork.Application.Interfaces.Repositories;
using SocialNetwork.Domain.Entities;
using SocialNetwork.Domain.Enums;

namespace Persistence.Repositories;

public class EventRepository : IEventRepository
{
    private readonly IGenericRepository<Event> repository;

    public EventRepository(IGenericRepository<Event> repository)
    {
        this.repository = repository;
    }

    public async Task<IEnumerable<Event>> GetAllEventsWithFormatFilter(EventType format)
    {
        return await repository.Entities.Where(e => e.EventType == format).ToListAsync();
    }
}