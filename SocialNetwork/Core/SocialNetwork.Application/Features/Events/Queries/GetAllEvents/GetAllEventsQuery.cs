using MediatR;

namespace SocialNetwork.Application.Features.Events.Queries.GetAllEvents;

public record GetAllEventsQuery() : IRequest<IEnumerable<GetAllEventsDto>>;
