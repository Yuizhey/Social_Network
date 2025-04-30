using MediatR;
using Microsoft.AspNetCore.Mvc;
using Persistence.Contexts;
using SocialNetwork.Application.Features.Events.Queries.GetAllEvents;
using SocialNetwork.Models.Events;

namespace SocialNetwork.Controllers;

public class EventsController : Controller
{
    private readonly IMediator _mediator;
    public EventsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<IActionResult> Index()
    {
        var query = new GetAllEventsQuery();
        var model = new EventVM()
        {
            Events = await _mediator.Send(query)
        };
        
        return View(model);
    }
}