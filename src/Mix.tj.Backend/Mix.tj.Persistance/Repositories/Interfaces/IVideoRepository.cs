using Mix.tj.Domain.Common.Commands;
using Mix.tj.Domain.Common.Queries;
using Mix.tj.Domain.Entities.Infrastructure;
using System.Linq.Expressions;

namespace Mix.tj.Persistance.Repositories.Interfaces;

public interface IVideoRepository
{
    IQueryable<Video> Get(
             Expression<Func<Video, bool>>? predicate = default,
             QueryOptions queryOptions = default);

    ValueTask<Video?> GetByIdAsync(
        Guid id,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default);

    ValueTask<IList<Video>> GetByIdsAsync(
        IEnumerable<Guid> ids,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<Video> CreateAsync(
        Video video,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<Video> UpdateAsync(
        Video video,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<Video?> DeleteAsync(
        Video video,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<Video?> DeleteByIdAsync(
        Guid id,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);
}