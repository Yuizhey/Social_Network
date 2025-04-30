using MediatR;

namespace SocialNetwork.Application.Features.Events.Queries.GetAllEvents;

public record GetAllEventsQuery(string formatType) : IRequest<IEnumerable<GetAllEventsDto>>;
