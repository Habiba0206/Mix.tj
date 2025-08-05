using Mix.tj.Application.Identity.Models;

namespace Mix.tj.Application.Identity.Services;

public interface IAuthAggregationService
{
    ValueTask<bool> SignUpAsync(SignUpDetails signUpDetails, CancellationToken cancellationToken = default);

    ValueTask<string> SignInAsync(SignInDetails signInDetails, CancellationToken cancellationToken = default);
}