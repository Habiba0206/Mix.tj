using Mix.tj.Domain.Common.Commands;
using Mix.tj.Application.Identity.Models;

namespace Mix.tj.Application.Identity.Commands;

public class UserUpdateCommand : ICommand<UserDto>
{
    public UserDto UserDto { get; set; }
}
