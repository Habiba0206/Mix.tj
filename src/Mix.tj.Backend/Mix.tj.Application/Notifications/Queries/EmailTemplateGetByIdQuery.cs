using Mix.tj.Domain.Common.Queries;
using Mix.tj.Application.Notifications.Models;

namespace Mix.tj.Application.Notifications.Queries;

public class EmailTemplateGetByIdQuery : IQuery<EmailTemplateDto?>
{
    public Guid EmailTemplateId { get; set; }
}
