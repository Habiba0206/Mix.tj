using Mix.tj.Domain.Common.Commands;

namespace Mix.tj.Application.Comments.Commands;

public class CommentDeleteByIdCommand : ICommand<bool>
{
    public Guid CommentId { get; set; }
}
