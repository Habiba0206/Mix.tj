using Mix.tj.Domain.Common.Commands;
using Mix.tj.Domain.Common.Queries;
using Mix.tj.Domain.Entities.Identity;
using System.Linq.Expressions;

namespace Mix.tj.Persistance.Repositories.Interfaces;

public interface IUserRepository
{
    IQueryable<User> Get(
             Expression<Func<User, bool>>? predicate = default,
             QueryOptions queryOptions = default);

    ValueTask<User?> GetByIdAsync(
        Guid id,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default);

    ValueTask<IList<User>> GetByIdsAsync(
        IEnumerable<Guid> ids,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<User> CreateAsync(
        User user,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<User> UpdateAsync(
        User user,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<User?> DeleteAsync(
        User user,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<User?> DeleteByIdAsync(
        Guid id,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);
}
