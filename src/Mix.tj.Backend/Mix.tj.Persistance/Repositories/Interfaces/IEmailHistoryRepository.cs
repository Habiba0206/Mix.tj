using Mix.tj.Domain.Common.Commands;
using Mix.tj.Domain.Common.Queries;
using Mix.tj.Domain.Entities.Notification;
using System.Linq.Expressions;

namespace Mix.tj.Persistance.Repositories.Interfaces;

public interface IEmailHistoryRepository
{
    IQueryable<EmailHistory> Get(
             Expression<Func<EmailHistory, bool>>? predicate = default,
             QueryOptions queryOptions = default);

    ValueTask<EmailHistory?> GetByIdAsync(
        Guid id,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default);

    ValueTask<IList<EmailHistory>> GetByIdsAsync(
        IEnumerable<Guid> ids,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<EmailHistory> CreateAsync(
        EmailHistory emailHistory,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);
}