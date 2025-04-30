namespace SocialNetwork.Application.Features.Events.Queries.GetAllEvents;

public class GetAllEventsDto
{
    public int Id { get; set; }
    
    public required string Title{ get; set; }

    public int InterestedCount { get; set; }

    public int GoingCount { get; set; }

    public required string Author { get; set; }

    public DateTime EventDate { get; set; }
}