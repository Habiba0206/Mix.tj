using Mix.tj.Domain.Common.Entities;
using Mix.tj.Domain.Entities.Identity;

namespace Mix.tj.Domain.Entities.Infrastructure;

public class Like : AuditableEntity
{
    public Guid UserId { get; set; }
    public Guid NewsId  { get; set; }
    public User User { get; set; }
    public News News { get; set; }
}
