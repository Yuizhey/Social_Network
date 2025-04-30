using MediatR;
using SocialNetwork.Application.Interfaces.Repositories;

namespace SocialNetwork.Application.Features.Posts.Queries.GetByUserPageId;

public class GetByUserPageIdQueryHandler : IRequestHandler<GetByUserPageIdQuery, IEnumerable<GetByUserPageIdDto>>
{
    private readonly IPostRepository postRepository;

    public GetByUserPageIdQueryHandler(IPostRepository postRepository)
    {
        this.postRepository = postRepository;
    }
    
    public async Task<IEnumerable<GetByUserPageIdDto>> Handle(GetByUserPageIdQuery request, CancellationToken cancellationToken)
    {
        var data = await postRepository.GetGetByUserPageIdAll(request.UserPageId);

        var result = data.Select(p => new GetByUserPageIdDto
        {
            Id = p.Id,
            UserPageId = p.UserPageId,
            Content = p.Content,
            LikeCount = p.LikeCount,
            DislikeCount = p.LikeCount
        });
        
        return result ?? new List<GetByUserPageIdDto>();
    }
}