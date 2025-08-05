using Mix.tj.Application.Notifications.Models;

namespace Mix.tj.Application.Notifications.Services;

public interface IEmailSenderService
{
    ValueTask<bool> SendAsync(EmailMessage emailMessage, CancellationToken cancellationToken = default);
}
