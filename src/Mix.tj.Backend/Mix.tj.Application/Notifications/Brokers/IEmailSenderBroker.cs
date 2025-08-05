using Mix.tj.Application.Notifications.Models;

namespace Mix.tj.Application.Notifications.Brokers;

public interface IEmailSenderBroker
{
    ValueTask<bool> SendAsync(EmailMessage emailMessage, CancellationToken cancellationToken = default);
}