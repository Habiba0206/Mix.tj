using Mix.tj.Domain.Common.Queries;
using Mix.tj.Application.Notifications.Models;

namespace Mix.tj.Application.Notifications.Queries;

public class EmailHistoryGetByIdQuery : IQuery<EmailHistoryDto?>
{
    public Guid EmailHistoryId { get; set; }
}
