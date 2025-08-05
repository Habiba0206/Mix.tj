using Type = Mix.tj.Domain.Enums.NotificationType;

namespace Mix.tj.Domain.Entities.Notification;

public class EmailTemplate : NotificationTemplate
{
    public EmailTemplate()
    {
        Type = Type.Email;
    }

    public string Subject { get; set; } = default!;
}