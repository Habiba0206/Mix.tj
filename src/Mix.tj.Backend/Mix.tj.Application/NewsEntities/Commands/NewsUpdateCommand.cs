using Mix.tj.Domain.Common.Commands;
using Mix.tj.Application.NewsEntities.Models;

namespace Mix.tj.Application.NewsEntities.Commands;

public class NewsUpdateCommand : ICommand<NewsDto>
{
    public NewsDto NewsDto { get; set; }
}
