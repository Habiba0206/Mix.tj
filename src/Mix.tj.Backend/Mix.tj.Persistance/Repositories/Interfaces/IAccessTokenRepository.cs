using Mix.tj.Domain.Common.Commands;
using Mix.tj.Domain.Entities.Identity;

namespace Mix.tj.Persistance.Repositories.Interfaces;

public interface IAccessTokenRepository
{
    ValueTask<AccessToken> CreateAsync(
        AccessToken accessToken,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default);
    ValueTask<AccessToken?> GetByIdAsync(
        Guid accessTokeId,
        CancellationToken cancellationToken = default);
    ValueTask<AccessToken> UpdateAsync(
        AccessToken accessToken,
        CancellationToken cancellationToken = default);
}
