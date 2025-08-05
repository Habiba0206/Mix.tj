using Mix.tj.Domain.Common.Exceptions;
using Mix.tj.Domain.Entities;
using Mix.tj.Application.Notifications.Events;
using Mix.tj.Application.Notifications.Models;
using Mix.tj.Domain.Entities.Notification;

namespace Mix.tj.Application.Notifications.Services;

public interface INotificationAggregatorService
{
    public ValueTask<FuncResult<bool>> SendAsync(ProcessNotificationEvent processNotificationEvent, CancellationToken cancellationToken = default);

    public ValueTask<IList<NotificationTemplate>> GetTemplatesByFilterAsync(
        NotificationTemplateFilter notificationTemplateFilter,
        CancellationToken cancellationToken = default
        );
}
