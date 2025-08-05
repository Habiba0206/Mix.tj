using Mix.tj.Application.Identity.Models;
using Mix.tj.Domain.Common.Queries;
using Mix.tj.Application.Notifications.Models;

namespace Mix.tj.Application.Notifications.Queries;

public class EmailTemplateGetQuery : IQuery<ICollection<EmailTemplateDto>>
{
    public EmailTemplateFilter EmailTemplateFilter { get; set; }
}
