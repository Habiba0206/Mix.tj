using Mix.tj.Domain.Common.Exceptions;
using Mix.tj.Application.Notifications.Models;

namespace Mix.tj.Application.Notifications.Services;

public interface IEmailOrchestrationService
{
    ValueTask<FuncResult<bool>> SendAsync(EmailProcessNotificationEvent @event, CancellationToken cancellationToken = default);
}
