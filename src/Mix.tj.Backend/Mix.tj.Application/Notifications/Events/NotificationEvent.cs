using Mix.tj.Domain.Common.Events;

namespace Mix.tj.Application.Notifications.Events;

public record NotificationEvent : EventBase
{
    public Guid SenderUserId { get; set; }

    public Guid ReceiverUserId { get; set; }
}
