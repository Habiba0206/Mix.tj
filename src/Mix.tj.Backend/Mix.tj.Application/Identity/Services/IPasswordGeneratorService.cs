using Mix.tj.Domain.Entities.Identity;

namespace Mix.tj.Application.Identity.Services;

public interface IPasswordGeneratorService
{
    string GeneratePassword();

    string GetValidatedPassword(string password, User user);
}