using Mix.tj.Application.Likes.Models;
using Mix.tj.Domain.Common.Queries;

namespace Mix.tj.Application.Likes.Queries;

public class LikeGetQuery : IQuery<ICollection<LikeDto>>
{
    public LikeFilter LikeFilter { get; set; }
}
