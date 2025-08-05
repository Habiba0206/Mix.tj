using Mix.tj.Application.Likes.Models;
using Mix.tj.Domain.Common.Queries;

namespace Mix.tj.Application.Likes.Queries;

public class LikeGetByIdQuery : IQuery<LikeDto?>
{
    public Guid LikeId { get; set; }
}
