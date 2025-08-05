using Mix.tj.Domain.Common.Commands;
using Mix.tj.Domain.Common.Queries;
using System.Linq.Expressions;
using Mix.tj.Domain.Entities.Infrastructure;
using Mix.tj.Application.NewsEntities.Models;

namespace Mix.tj.Application.NewsEntities.Services;

public interface INewsService
{
    IQueryable<News> Get(
             Expression<Func<News, bool>>? predicate = default,
             QueryOptions queryOptions = default);

    IQueryable<News> Get(
        NewsFilter answerFilter,
        QueryOptions queryOptions = default);

    ValueTask<News?> GetByIdAsync(
        Guid id,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default);

    ValueTask<IList<News>> GetByIdsAsync(
        IEnumerable<Guid> ids,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<News> CreateAsync(
        News news,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<News> UpdateAsync(
        News news,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<News?> DeleteAsync(
        News book,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    ValueTask<News?> DeleteByIdAsync(
        Guid id,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);
}
