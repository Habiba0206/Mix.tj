using Mix.tj.Application.Comments.Models;
using Mix.tj.Domain.Common.Commands;

namespace Mix.tj.Application.Comments.Commands;

public class CommentUpdateCommand : ICommand<CommentDto>
{
    public CommentDto CommentDto { get; set; }
}
