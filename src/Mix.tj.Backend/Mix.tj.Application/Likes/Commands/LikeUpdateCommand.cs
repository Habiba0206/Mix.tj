using Mix.tj.Application.Likes.Models;
using Mix.tj.Domain.Common.Commands;

namespace Mix.tj.Application.Likes.Commands;

public class LikeUpdateCommand : ICommand<LikeDto>
{
    public LikeDto LikeDto { get; set; }
}
