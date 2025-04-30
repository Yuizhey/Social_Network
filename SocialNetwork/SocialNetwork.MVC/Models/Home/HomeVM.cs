using SocialNetwork.Application.Features.Posts.Queries.GetByUserPageId;

namespace SocialNetwork.Models.Home;

public class HomeVM
{
    public IEnumerable<GetByUserPageIdDto> Feeds { get; set; }
}