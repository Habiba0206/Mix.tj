using Mix.tj.Domain.Common.Commands;
using Mix.tj.Application.Notifications.Models;

namespace Mix.tj.Application.Notifications.Commands;

public class EmailTemplateCreateCommand : ICommand<EmailTemplateDto>
{
    public EmailTemplateDto EmailTemplateDto { get; set; }
}
