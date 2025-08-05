using Mix.tj.Domain.Common.Entities;
using Mix.tj.Domain.Entities.Identity;
using Mix.tj.Domain.Enums;

namespace Mix.tj.Domain.Entities.Infrastructure;

public class Video : AuditableEntity
{
    public Guid UserId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; } 
    public string Url { get; set; }
    public VideoType VideoType { get; set; }
    public User User { get; set; }
}
