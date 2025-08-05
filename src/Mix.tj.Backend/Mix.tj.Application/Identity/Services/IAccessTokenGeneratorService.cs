using Mix.tj.Domain.Entities;
using Mix.tj.Domain.Entities.Identity;

namespace Mix.tj.Application.Identity.Services;

public interface IAccessTokenGeneratorService
{
    AccessToken GetToken(User user);

    Guid GetTokenId(string accessToken);
}