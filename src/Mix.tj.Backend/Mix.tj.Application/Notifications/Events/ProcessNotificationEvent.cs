using Mix.tj.Domain.Enums;

namespace Mix.tj.Application.Notifications.Events;

public record ProcessNotificationEvent : NotificationEvent
{
    public NotificationTemplateType TemplateType { get; set; }

    public NotificationType? Type { get; set; }

    public Dictionary<string, string>? Variables { get; set; }
}
