using Mix.tj.Domain.Common.Commands;
using Mix.tj.Application.NewsEntities.Models;

namespace Mix.tj.Application.NewsEntities.Commands;

public record NewsCreateCommand : ICommand<NewsDto>
{
    public NewsDto NewsDto { get; set; }
}
