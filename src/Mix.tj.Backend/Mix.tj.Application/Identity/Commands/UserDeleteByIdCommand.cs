using Mix.tj.Domain.Common.Commands;

namespace Mix.tj.Application.Identity.Commands;

public class UserDeleteByIdCommand : ICommand<bool>
{
    public Guid UserId { get; set; }
}
