using Mix.tj.Domain.Common.Commands;

namespace Mix.tj.Application.NewsEntities.Commands;

public class NewsDeleteByIdCommand : ICommand<bool>
{
    public Guid NewsId { get; set; }
}
