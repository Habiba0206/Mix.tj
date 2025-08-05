using Mix.tj.Domain.Common.Commands;
using Mix.tj.Domain.Common.Queries;
using Mix.tj.Domain.Entities.Infrastructure;
using Mix.tj.Persistance.Caching.Brokers;
using Mix.tj.Persistance.DataContexts;
using Mix.tj.Persistance.Repositories.Interfaces;
using System.Linq.Expressions;

namespace Mix.tj.Persistance.Repositories;

public class VideoRepository(AppDbContext appDbContext, ICacheBroker cacheBroker) :
    EntityRepositoryBase<Video, AppDbContext>(appDbContext, cacheBroker),
    IVideoRepository

{
    public IQueryable<Video> Get(
        Expression<Func<Video, bool>>? predicate = null,
        QueryOptions queryOptions = default) =>
    base.Get(predicate, queryOptions);

    public ValueTask<Video?> GetByIdAsync(
        Guid id,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default) =>
    base.GetByIdAsync(id, queryOptions, cancellationToken);

    public ValueTask<IList<Video>> GetByIdsAsync(
        IEnumerable<Guid> ids,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default) =>
    base.GetByIdsAsync(ids, queryOptions, cancellationToken);

    public ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default) =>
    base.CheckByIdAsync(id, cancellationToken);

    public ValueTask<Video> CreateAsync(
        Video video,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default) =>
    base.CreateAsync(video, commandOptions, cancellationToken);

    public ValueTask<Video> UpdateAsync(
        Video video,
        CommandOptions commandOptions,
        CancellationToken cancellationToken) =>
    base.UpdateAsync(video, commandOptions, cancellationToken);

    public ValueTask<Video?> DeleteAsync(
        Video video,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default) =>
    base.DeleteAsync(video, commandOptions, cancellationToken);

    public ValueTask<Video?> DeleteByIdAsync(
        Guid id,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default) =>
    base.DeleteByIdAsync(id, commandOptions, cancellationToken);
}