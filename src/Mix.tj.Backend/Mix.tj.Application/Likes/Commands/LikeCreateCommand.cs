using Mix.tj.Application.Likes.Models;
using Mix.tj.Domain.Common.Commands;

namespace Mix.tj.Application.Likes.Commands;

public record LikeCreateCommand : ICommand<LikeDto>
{
    public LikeDto LikeDto { get; set; }
}
