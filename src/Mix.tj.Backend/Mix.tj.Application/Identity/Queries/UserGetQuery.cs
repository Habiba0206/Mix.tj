using Mix.tj.Domain.Common.Queries;
using Mix.tj.Application.Identity.Models;

namespace Mix.tj.Application.Identity.Queries;

public class UserGetQuery : IQuery<ICollection<UserDto>>
{
    public UserFilter UserFilter { get; set; }
}
