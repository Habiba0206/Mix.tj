using Mix.tj.Domain.Common.Commands;
using Mix.tj.Domain.Common.Queries;
using Mix.tj.Domain.Entities.Infrastructure;
using Mix.tj.Persistance.Caching.Brokers;
using Mix.tj.Persistance.DataContexts;
using Mix.tj.Persistance.Repositories.Interfaces;
using System.Linq.Expressions;

namespace Mix.tj.Persistance.Repositories;

public class CommentRepository(AppDbContext appDbContext, ICacheBroker cacheBroker) :
    EntityRepositoryBase<Comment, AppDbContext>(appDbContext, cacheBroker),
    ICommentRepository

{
    public IQueryable<Comment> Get(
        Expression<Func<Comment, bool>>? predicate = null,
        QueryOptions queryOptions = default) =>
    base.Get(predicate, queryOptions);

    public ValueTask<Comment?> GetByIdAsync(
        Guid id,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default) =>
    base.GetByIdAsync(id, queryOptions, cancellationToken);

    public ValueTask<IList<Comment>> GetByIdsAsync(
        IEnumerable<Guid> ids,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default) =>
    base.GetByIdsAsync(ids, queryOptions, cancellationToken);

    public ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default) =>
    base.CheckByIdAsync(id, cancellationToken);

    public ValueTask<Comment> CreateAsync(
        Comment comment,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default) =>
    base.CreateAsync(comment, commandOptions, cancellationToken);

    public ValueTask<Comment> UpdateAsync(
        Comment comment,
        CommandOptions commandOptions,
        CancellationToken cancellationToken) =>
    base.UpdateAsync(comment, commandOptions, cancellationToken);

    public ValueTask<Comment?> DeleteAsync(
        Comment comment,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default) =>
    base.DeleteAsync(comment, commandOptions, cancellationToken);

    public ValueTask<Comment?> DeleteByIdAsync(
        Guid id,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default) =>
    base.DeleteByIdAsync(id, commandOptions, cancellationToken);
}