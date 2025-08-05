﻿using Mix.tj.Domain.Entities.Identity;
using Mix.tj.Domain.Entities.Notification;

namespace Mix.tj.Application.Notifications.Events;

public record RenderNotificationEvent : NotificationEvent
{
    public NotificationTemplate Template { get; set; } = default!;

    public User SenderUser { get; init; } = default!;

    public User ReceiverUser { get; init; } = default!;

    public Dictionary<string, string> Variables { get; set; } = new();
}
