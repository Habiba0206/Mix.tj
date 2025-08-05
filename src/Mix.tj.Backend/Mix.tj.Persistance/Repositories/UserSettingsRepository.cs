using Mix.tj.Domain.Common.Commands;
using Mix.tj.Domain.Common.Queries;
using Mix.tj.Domain.Entities.Identity;
using Mix.tj.Persistance.Caching.Brokers;
using Mix.tj.Persistance.DataContexts;
using Mix.tj.Persistance.Repositories.Interfaces;

namespace Mix.tj.Persistance.Repositories;

public class UserSettingsRepository(AppDbContext appDbContext, ICacheBroker cacheBroker) :
    EntityRepositoryBase<UserSettings, AppDbContext>(appDbContext, cacheBroker),
    IUserSettingsRepository

{
    public ValueTask<UserSettings?> GetByIdAsync(
        Guid id,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default) =>
    base.GetByIdAsync(id, queryOptions, cancellationToken);

    public ValueTask<UserSettings> CreateAsync(
        UserSettings userSettings,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default) =>
    base.CreateAsync(userSettings, commandOptions, cancellationToken);
}
