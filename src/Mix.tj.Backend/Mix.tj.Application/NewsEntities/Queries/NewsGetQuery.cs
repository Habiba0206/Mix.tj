using Mix.tj.Domain.Common.Queries;
using Mix.tj.Application.NewsEntities.Models;

namespace Mix.tj.Application.NewsEntities.Queries;

public class NewsGetQuery : IQuery<ICollection<NewsDto>>
{
    public NewsFilter BookFilter { get; set; }
}
