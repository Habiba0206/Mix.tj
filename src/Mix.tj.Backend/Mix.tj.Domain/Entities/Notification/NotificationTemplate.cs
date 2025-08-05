using Mix.tj.Domain.Common.Entities;
using Mix.tj.Domain.Enums;

namespace Mix.tj.Domain.Entities.Notification;

public abstract class NotificationTemplate : AuditableEntity
{
    public NotificationType Type { get; set; }

    public NotificationTemplateType TemplateType { get; set; }

    public string Content { get; set; } = default!;

    public IList<NotificationHistory> Histories { get; set; } = new List<NotificationHistory>();
    public Guid Id { get; set; }
}