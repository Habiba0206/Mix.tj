using Mix.tj.Domain.Common.Commands;
using Mix.tj.Domain.Common.Queries;
using Mix.tj.Domain.Entities.Infrastructure;
using Mix.tj.Persistance.Caching.Brokers;
using Mix.tj.Persistance.DataContexts;
using Mix.tj.Persistance.Repositories.Interfaces;
using System.Linq.Expressions;

namespace Mix.tj.Persistance.Repositories;

public class LikeRepository(AppDbContext appDbContext, ICacheBroker cacheBroker) :
    EntityRepositoryBase<Like, AppDbContext>(appDbContext, cacheBroker),
    ILikeRepository

{
    public IQueryable<Like> Get(
        Expression<Func<Like, bool>>? predicate = null,
        QueryOptions queryOptions = default) =>
    base.Get(predicate, queryOptions);

    public ValueTask<Like?> GetByIdAsync(
        Guid id,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default) =>
    base.GetByIdAsync(id, queryOptions, cancellationToken);

    public ValueTask<IList<Like>> GetByIdsAsync(
        IEnumerable<Guid> ids,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default) =>
    base.GetByIdsAsync(ids, queryOptions, cancellationToken);

    public ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default) =>
    base.CheckByIdAsync(id, cancellationToken);

    public ValueTask<Like> CreateAsync(
        Like like,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default) =>
    base.CreateAsync(like, commandOptions, cancellationToken);

    public ValueTask<Like> UpdateAsync(
        Like like,
        CommandOptions commandOptions,
        CancellationToken cancellationToken) =>
    base.UpdateAsync(like, commandOptions, cancellationToken);

    public ValueTask<Like?> DeleteAsync(
        Like like,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default) =>
    base.DeleteAsync(like, commandOptions, cancellationToken);

    public ValueTask<Like?> DeleteByIdAsync(
        Guid id,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default) =>
    base.DeleteByIdAsync(id, commandOptions, cancellationToken);
}