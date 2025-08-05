using Mix.tj.Domain.Common.Commands;
using Mix.tj.Domain.Common.Queries;
using Mix.tj.Domain.Entities.Infrastructure;
using System.Linq.Expressions;

namespace Mix.tj.Persistance.Repositories.Interfaces;

public interface INewsRepository
{
    IQueryable<News> Get(
             Expression<Func<News, bool>>? predicate = default,
             QueryOptions queryOptions = default);

    ValueTask<News?> GetByIdAsync(
        Guid id,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default);

    ValueTask<IList<News>> GetByIdsAsync(
        IEnumerable<Guid> ids,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<News> CreateAsync(
        News news,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<News> UpdateAsync(
        News news,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<News?> DeleteAsync(
        News news,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<News?> DeleteByIdAsync(
        Guid id,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);
}