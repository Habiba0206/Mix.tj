using Mix.tj.Domain.Entities;
using Mix.tj.Domain.Entities.Notification;
using Newtonsoft.Json;

namespace Mix.tj.Application.Notifications.Models;

public class EmailMessage : NotificationMessage
{
    public string ReceiverEmailAddress { get; set; } = default!;

    public string SenderEmailAddress { get; set; } = default!;

    public string Subject { get; set; } = default!;

    [JsonIgnore]
    public EmailTemplate EmailTemplate
    {
        get => (EmailTemplate)Template;
        set => Template = value;
    }
}