using Mix.tj.Domain.Common.Entities;
using Mix.tj.Domain.Enums;

namespace Mix.tj.Domain.Entities.Identity;

public class UserSettings : AuditableEntity
{
    public NotificationType? PreferredNotificationType { get; set; }

    /// <summary>
    ///     Gets or sets the user Id
    /// </summary>
    public Guid Id { get; set; }
}