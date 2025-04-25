namespace SocialNetwork.Domain.Entities;

public class NotificationSettings
{
    public int UserId { get; set; }
    public bool EnableEmailNotifications { get; set; } = true;
    public bool EnableWebNotifications { get; set; } = true;
    public bool EnablePhoneNotifications { get; set; } = true;
}