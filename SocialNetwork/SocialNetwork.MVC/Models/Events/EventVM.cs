using SocialNetwork.Application.Features.Events.Queries.GetAllEvents;

namespace SocialNetwork.Models.Events;

public class EventVM
{
    public IEnumerable<GetAllEventsDto> Events { get; set; }
}