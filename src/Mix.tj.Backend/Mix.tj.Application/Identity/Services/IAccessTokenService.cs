using Mix.tj.Domain.Common.Commands;
using Mix.tj.Domain.Entities;
using Mix.tj.Domain.Entities.Identity;

namespace Mix.tj.Application.Identity.Services;

public interface IAccessTokenService
{
    ValueTask<AccessToken> CreateAsync(
        AccessToken accessToken,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);
    ValueTask<AccessToken?> GetByIdAsync(
        Guid accessTokeId,
        CancellationToken cancellationToken = default);
    ValueTask RevokeAsync(
        Guid accessTokenId,
        CancellationToken cancellationToken = default);
}
