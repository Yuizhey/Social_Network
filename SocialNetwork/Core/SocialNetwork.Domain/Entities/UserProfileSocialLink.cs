using SocialNetwork.Domain.Enums;

namespace SocialNetwork.Domain.Entities;

public class UserProfileSocialLink
{
    public int UserId { get; set; }
    public required string SocialLinkUrl { get; set; }
    public SocialNetworkType SocialNetworkType { get; set; }
}