using Mix.tj.Domain.Enums;
using Mix.tj.Application.Notifications.Events;

namespace Mix.tj.Application.Notifications.Models;

public record EmailProcessNotificationEvent : ProcessNotificationEvent
{
    public EmailProcessNotificationEvent()
    {
        Type = NotificationType.Email;
    }
}