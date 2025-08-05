using Mix.tj.Domain.Common.Commands;

namespace Mix.tj.Application.Likes.Commands;

public class LikeDeleteByIdCommand : ICommand<bool>
{
    public Guid LikeId { get; set; }
}
