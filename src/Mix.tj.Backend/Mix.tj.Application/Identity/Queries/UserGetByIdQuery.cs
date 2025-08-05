using Mix.tj.Domain.Common.Queries;
using Mix.tj.Application.Identity.Models;

namespace Mix.tj.Application.Identity.Queries;

public class UserGetByIdQuery : IQuery<UserDto?>
{
    public Guid UserId { get; set; }
}
