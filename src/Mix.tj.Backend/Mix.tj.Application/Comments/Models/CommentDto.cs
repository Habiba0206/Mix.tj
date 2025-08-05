using Mix.tj.Domain.Entities.Identity;

namespace Mix.tj.Application.Comments.Models;

public class CommentDto
{
    public Guid? Id { get; set; }
    public Guid UserId { get; set; }
    public string Text { get; set; }
    public string Reply { get; set; }
}
