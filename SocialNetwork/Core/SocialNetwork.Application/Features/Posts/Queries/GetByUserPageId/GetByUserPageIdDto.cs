using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Application.Features.Posts.Queries.GetByUserPageId;

public class GetByUserPageIdDto
{
    public int Id { get; set; }
    /// <summary>
    /// у кого их юзеров этот пост
    /// </summary>
    public int UserPageId { get; set; }

    /// <summary>
    /// сам контент поста
    /// </summary>
    public string? Content { get; set; }

    /// <summary>
    /// количество лайков
    /// </summary>
    public int LikeCount { get; set; }

    /// <summary>
    /// количество дизлайков
    /// </summary>
    public int DislikeCount { get; set; }

    public List<PostCommentDto> Comments { get; set; }
}