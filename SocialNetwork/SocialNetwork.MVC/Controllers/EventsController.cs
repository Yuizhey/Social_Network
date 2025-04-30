using MediatR;
using Microsoft.AspNetCore.Mvc;
using Persistence.Contexts;
using SocialNetwork.Application.Features.Events.Queries.GetAllEvents;
using SocialNetwork.Application.Interfaces.Repositories;
using SocialNetwork.Domain.Entities;
using SocialNetwork.Models.Events;

namespace SocialNetwork.Controllers;

public class EventsController : Controller
{
    private readonly IMediator _mediator;
    public EventsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<IActionResult> Index([FromQuery]string formatType = "offline")
    {
        var query = new GetAllEventsQuery(formatType);
        var model = new EventVM()
        {
            Events = await _mediator.Send(query),
            CurrentFormatType = formatType
        };
        
        return View(model);
    }
}