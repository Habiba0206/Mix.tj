using Mix.tj.Domain.Common.Commands;
using Mix.tj.Domain.Common.Queries;
using Mix.tj.Domain.Entities.Infrastructure;
using Mix.tj.Persistance.Caching.Brokers;
using Mix.tj.Persistance.DataContexts;
using Mix.tj.Persistance.Repositories.Interfaces;
using System.Linq.Expressions;

namespace Mix.tj.Persistance.Repositories;

public class NewsRepository(AppDbContext appDbContext, ICacheBroker cacheBroker) :
    EntityRepositoryBase<News, AppDbContext>(appDbContext, cacheBroker),
    INewsRepository

{
    public IQueryable<News> Get(
        Expression<Func<News, bool>>? predicate = null,
        QueryOptions queryOptions = default) =>
    base.Get(predicate, queryOptions);

    public ValueTask<News?> GetByIdAsync(
        Guid id,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default) =>
    base.GetByIdAsync(id, queryOptions, cancellationToken);

    public ValueTask<IList<News>> GetByIdsAsync(
        IEnumerable<Guid> ids,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default) =>
    base.GetByIdsAsync(ids, queryOptions, cancellationToken);

    public ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default) =>
    base.CheckByIdAsync(id, cancellationToken);

    public ValueTask<News> CreateAsync(
        News news,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default) =>
    base.CreateAsync(news, commandOptions, cancellationToken);

    public ValueTask<News> UpdateAsync(
        News news,
        CommandOptions commandOptions,
        CancellationToken cancellationToken) =>
    base.UpdateAsync(news, commandOptions, cancellationToken);

    public ValueTask<News?> DeleteAsync(
        News news,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default) =>
    base.DeleteAsync(news, commandOptions, cancellationToken);

    public ValueTask<News?> DeleteByIdAsync(
        Guid id,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default) =>
    base.DeleteByIdAsync(id, commandOptions, cancellationToken);
}