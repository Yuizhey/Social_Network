namespace SocialNetwork.Domain.Entities;

public class NotificationPreferences
{
    public int UserId { get; set; }
    public bool NotifyOnNewMessage { get; set; } = true;
    public bool NotifyOnPhotoLike { get; set; } = true;
    public bool NotifyOnPhotoShare { get; set; } = true;
    public bool NotifyOnNewFollower { get; set; } = true;
    public bool NotifyOnPostLike { get; set; } = true;
    public bool NotifyOnMention { get; set; } = true;
    public bool NotifyOnFollowRequest { get; set; } = true;
}