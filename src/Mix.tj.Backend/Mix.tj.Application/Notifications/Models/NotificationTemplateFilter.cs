using Mix.tj.Domain.Enums;
using Mix.tj.Domain.Common.Queries;

namespace Mix.tj.Application.Notifications.Models;

public class NotificationTemplateFilter : FilterPagination
{
    public IList<NotificationType> TemplateType { get; set; }
}