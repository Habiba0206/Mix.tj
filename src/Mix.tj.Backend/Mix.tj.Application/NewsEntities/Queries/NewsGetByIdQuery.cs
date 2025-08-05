using Mix.tj.Application.NewsEntities.Models;
using Mix.tj.Domain.Common.Queries;

namespace Mix.tj.Application.NewsEntities.Queries;

public class NewsGetByIdQuery : IQuery<NewsDto?>
{
    public Guid BookId { get; set; }
}
