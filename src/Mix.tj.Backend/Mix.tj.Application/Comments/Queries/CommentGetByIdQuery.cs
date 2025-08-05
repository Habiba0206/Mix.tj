using Mix.tj.Application.Comments.Models;
using Mix.tj.Domain.Common.Queries;

namespace Mix.tj.Application.Comments.Queries;

public class CommentGetByIdQuery : IQuery<CommentDto?>
{
    public Guid CommentId { get; set; }
}
