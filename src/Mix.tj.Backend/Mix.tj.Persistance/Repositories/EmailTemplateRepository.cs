using System.Linq.Expressions;
using Mix.tj.Persistance.DataContexts;
using Mix.tj.Persistance.Caching.Brokers;
using Mix.tj.Persistance.Repositories.Interfaces;
using Mix.tj.Domain.Entities.Notification;
using Mix.tj.Domain.Common.Queries;
using Mix.tj.Domain.Common.Commands;

namespace Mix.tj.Persistance.Repositories;

public class EmailTemplateRepository(AppDbContext appDbContext, ICacheBroker cacheBroker) :
    EntityRepositoryBase<EmailTemplate, AppDbContext>(appDbContext, cacheBroker),
    IEmailTemplateRepository

{
    public IQueryable<EmailTemplate> Get(
        Expression<Func<EmailTemplate, bool>>? predicate = null,
        QueryOptions queryOptions = default) =>
    base.Get(predicate, queryOptions);

    public ValueTask<EmailTemplate?> GetByIdAsync(
        Guid id,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default) =>
    base.GetByIdAsync(id, queryOptions, cancellationToken);

    public ValueTask<IList<EmailTemplate>> GetByIdsAsync(
        IEnumerable<Guid> ids,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default) =>
    base.GetByIdsAsync(ids, queryOptions, cancellationToken);

    public ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default) =>
    base.CheckByIdAsync(id, cancellationToken);

    public ValueTask<EmailTemplate> CreateAsync(
        EmailTemplate emailTemplate,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default) =>
    base.CreateAsync(emailTemplate, commandOptions, cancellationToken);
}