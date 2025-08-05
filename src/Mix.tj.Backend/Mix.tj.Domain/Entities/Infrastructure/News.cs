using Mix.tj.Domain.Common.Entities;
using Mix.tj.Domain.Entities.Identity;
using Mix.tj.Domain.Enums;

namespace Mix.tj.Domain.Entities.Infrastructure;

public class News : AuditableEntity
{
    public Guid UserId  { get; set; }
    public string Headline { get; set; } = default!;
    public string Content { get; set; } = default!;
    public Category Category { get; set; }
    public IEnumerable<string> Tags { get; set; }
    public User User { get; set; }
    public IList<Like> Likes { get; set; }
}
