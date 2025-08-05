using Mix.tj.Domain.Common.Queries;
using Mix.tj.Application.Notifications.Models;

namespace Mix.tj.Application.Notifications.Queries;

public class EmailHistoryGetQuery : IQuery<ICollection<EmailHistoryDto>>
{
    public EmailHistoryFilter EmailHistoryFilter { get; set; }
}
