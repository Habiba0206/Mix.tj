using System.Linq.Expressions;
using Mix.tj.Persistance.DataContexts;
using Mix.tj.Persistance.Caching.Brokers;
using Mix.tj.Persistance.Repositories.Interfaces;
using Mix.tj.Domain.Entities.Notification;
using Mix.tj.Domain.Common.Queries;
using Mix.tj.Domain.Common.Commands;

namespace Mix.tj.Persistance.Repositories;

public class EmailHistoryRepository(AppDbContext appDbContext, ICacheBroker cacheBroker) :
    EntityRepositoryBase<EmailHistory, AppDbContext>(appDbContext, cacheBroker),
    IEmailHistoryRepository

{
    public IQueryable<EmailHistory> Get(
        Expression<Func<EmailHistory, bool>>? predicate = null,
        QueryOptions queryOptions = default) =>
    base.Get(predicate, queryOptions);

    public ValueTask<EmailHistory?> GetByIdAsync(
        Guid id,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default) =>
    base.GetByIdAsync(id, queryOptions, cancellationToken);

    public ValueTask<IList<EmailHistory>> GetByIdsAsync(
        IEnumerable<Guid> ids,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default) =>
    base.GetByIdsAsync(ids, queryOptions, cancellationToken);

    public ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default) =>
    base.CheckByIdAsync(id, cancellationToken);

    public ValueTask<EmailHistory> CreateAsync(
        EmailHistory emailHistory,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default) =>
    base.CreateAsync(emailHistory, commandOptions, cancellationToken);
}

