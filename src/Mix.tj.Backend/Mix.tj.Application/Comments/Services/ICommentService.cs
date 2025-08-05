using Mix.tj.Application.Comments.Models;
using Mix.tj.Domain.Common.Commands;
using Mix.tj.Domain.Common.Queries;
using Mix.tj.Domain.Entities.Infrastructure;
using System.Linq.Expressions;

namespace Mix.tj.Application.Comments.Services;

public interface ICommentService
{
    IQueryable<Comment> Get(
             Expression<Func<Comment, bool>>? predicate = default,
             QueryOptions queryOptions = default);

    IQueryable<Comment> Get(
        CommentFilter answerFilter,
        QueryOptions queryOptions = default);

    ValueTask<Comment?> GetByIdAsync(
        Guid id,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default);

    ValueTask<IList<Comment>> GetByIdsAsync(
        IEnumerable<Guid> ids,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<Comment> CreateAsync(
        Comment comment,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<Comment> UpdateAsync(
        Comment comment,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<Comment?> DeleteAsync(
        Comment comment,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<Comment?> DeleteByIdAsync(
        Guid id,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);
}
