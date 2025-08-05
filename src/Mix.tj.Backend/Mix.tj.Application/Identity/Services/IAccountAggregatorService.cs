using Mix.tj.Domain.Entities;
using Mix.tj.Domain.Entities.Identity;

namespace Mix.tj.Application.Identity.Services;

public interface IAccountAggregatorService
{
    ValueTask<bool> CreateUserAsync(User user, CancellationToken cancellationToken = default);
}