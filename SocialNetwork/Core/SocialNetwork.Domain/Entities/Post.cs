namespace SocialNetwork.Domain.Entities;

public class Post
{
    /// <summary>
    /// уникальный идентификатор поста
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// автор поста
    /// </summary>
    public int UserPageId { get; set; }
    
    /// <summary>
    /// текст поста
    /// </summary>
    public string Content { get; set; }
    
    /// <summary>
    /// количество отметок нравится
    /// </summary>
    public int LikeCount { get; set; }
    
    /// <summary>
    /// количество отметок не нравится
    /// </summary>
    public int DislikeCount { get; set; }
}