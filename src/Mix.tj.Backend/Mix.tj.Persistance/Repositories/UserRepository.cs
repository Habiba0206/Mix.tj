using System.Linq.Expressions;
using Mix.tj.Persistance.DataContexts;
using Mix.tj.Persistance.Caching.Brokers;
using Mix.tj.Persistance.Repositories.Interfaces;
using Mix.tj.Domain.Common.Commands;
using Mix.tj.Domain.Entities.Identity;
using Mix.tj.Domain.Common.Queries;

namespace Mix.tj.Persistance.Repositories;

public class UserRepository(AppDbContext appDbContext, ICacheBroker cacheBroker) :
    EntityRepositoryBase<User, AppDbContext>(appDbContext, cacheBroker),
    IUserRepository

{
    public IQueryable<User> Get(
        Expression<Func<User, bool>>? predicate = null,
        QueryOptions queryOptions = default) =>
    base.Get(predicate, queryOptions);

    public ValueTask<User?> GetByIdAsync(
        Guid id,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default) =>
    base.GetByIdAsync(id, queryOptions, cancellationToken);

    public ValueTask<IList<User>> GetByIdsAsync(
        IEnumerable<Guid> ids,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default) =>
    base.GetByIdsAsync(ids, queryOptions, cancellationToken);

    public ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default) =>
    base.CheckByIdAsync(id, cancellationToken);

    public ValueTask<User> CreateAsync(
        User user,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default) =>
    base.CreateAsync(user, commandOptions, cancellationToken);

    public ValueTask<User> UpdateAsync(
        User user,
        CommandOptions commandOptions,
        CancellationToken cancellationToken) =>
    base.UpdateAsync(user, commandOptions, cancellationToken);

    public ValueTask<User?> DeleteAsync(
        User user,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default) =>
    base.UpdateAsync(user, commandOptions, cancellationToken);

    public ValueTask<User?> DeleteByIdAsync(
        Guid id,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default) =>
    base.DeleteByIdAsync(id, commandOptions, cancellationToken);
}
