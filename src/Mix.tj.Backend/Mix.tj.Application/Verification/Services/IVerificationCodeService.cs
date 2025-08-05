using Mix.tj.Domain.Enums;

namespace Mix.tj.Application.Verification.Services;

public interface IVerificationCodeService
{
    ValueTask<VerificationType?> GetVerificationTypeAsync(string code, CancellationToken cancellationToken = default);
}
