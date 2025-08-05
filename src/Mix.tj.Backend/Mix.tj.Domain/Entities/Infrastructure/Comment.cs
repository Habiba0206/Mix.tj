using Mix.tj.Domain.Common.Entities;
using Mix.tj.Domain.Entities.Identity;

namespace Mix.tj.Domain.Entities.Infrastructure;

public class Comment : AuditableEntity
{
    public Guid UserId { get; set; }
    public string Text { get; set; }
    public string Reply { get; set; }
    public User User { get; set; }
}
