using Mix.tj.Application.Notifications.Models;

namespace Mix.tj.Application.Notifications.Events;

public record SendNotificationEvent : NotificationEvent
{
    public NotificationMessage Message { get; set; } = default!;
}
