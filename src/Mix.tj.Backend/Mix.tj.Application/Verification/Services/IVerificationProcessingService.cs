namespace Mix.tj.Application.Verification.Services;

public interface IVerificationProcessingService
{
    ValueTask<bool> Verify(string code, CancellationToken cancellationToken);
}
