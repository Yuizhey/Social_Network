namespace SocialNetwork.Domain.Entities;

public class EventAboutInformation
{
    public int EventId { get; set; }
    public string EventAboutText { get; set; }
    public int CreatedByUserId { get; set; }
}