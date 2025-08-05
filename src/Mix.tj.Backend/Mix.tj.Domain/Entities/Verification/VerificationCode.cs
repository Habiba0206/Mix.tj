using Mix.tj.Domain.Common.Entities;
using Mix.tj.Domain.Enums;

namespace Mix.tj.Domain.Entities.Verification;

public abstract class VerificationCode : AuditableEntity
{
    public VerificationCodeType CodeType { get; set; }

    public VerificationType Type { get; set; }

    public DateTimeOffset ExpiryTime { get; set; }

    public bool IsActive { get; set; }

    public string Code { get; set; } = default!;

    public string VerificationLink { get; set; } = default!;
}