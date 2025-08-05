using Mix.tj.Application.Likes.Models;
using Mix.tj.Domain.Common.Commands;
using Mix.tj.Domain.Common.Queries;
using Mix.tj.Domain.Entities.Infrastructure;
using System.Linq.Expressions;

namespace Mix.tj.Application.Likes.Services;

public interface ILikeService
{
    IQueryable<Like> Get(
             Expression<Func<Like, bool>>? predicate = default,
             QueryOptions queryOptions = default);

    IQueryable<Like> Get(
        LikeFilter answerFilter,
        QueryOptions queryOptions = default);

    ValueTask<Like?> GetByIdAsync(
        Guid id,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default);

    ValueTask<IList<Like>> GetByIdsAsync(
        IEnumerable<Guid> ids,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<Like> CreateAsync(
        Like book,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<Like> UpdateAsync(
        Like book,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<Like?> DeleteAsync(
        Like book,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<Like?> DeleteByIdAsync(
        Guid id,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);
}
