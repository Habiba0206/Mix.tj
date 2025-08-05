using Mix.tj.Application.Comments.Models;
using Mix.tj.Domain.Common.Queries;

namespace Mix.tj.Application.Comments.Queries;

public class CommentGetQuery : IQuery<ICollection<CommentDto>>
{
    public CommentFilter CommentFilter { get; set; }
}
