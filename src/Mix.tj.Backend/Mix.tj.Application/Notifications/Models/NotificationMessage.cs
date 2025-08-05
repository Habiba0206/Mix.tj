using Mix.tj.Domain.Entities;
using Mix.tj.Domain.Entities.Notification;

namespace Mix.tj.Application.Notifications.Models;

public abstract class NotificationMessage
{
    public string Body { get; set; } = default!;

    public NotificationTemplate Template { get; set; } = default!;

    public Dictionary<string, string> Variables { get; set; } = default!;

    public bool IsSuccessful { get; set; }

    public string? ErrorMessage { get; set; }
}