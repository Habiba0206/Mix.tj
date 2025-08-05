using Mix.tj.Application.Notifications.Models;

namespace Mix.tj.Application.Notifications.Services;

public interface IEmailRenderingService
{
    ValueTask<string> RenderAsync(
        EmailMessage emailMessage,
        CancellationToken cancellationToken = default
    );
}