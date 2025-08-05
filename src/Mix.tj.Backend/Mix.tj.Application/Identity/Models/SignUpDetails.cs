namespace Mix.tj.Application.Identity.Models;

public class SignUpDetails
{
    public string FirstName { get; set; } = default!;

    public string LastName { get; set; } = default!;

    public string EmailAddress { get; set; } = default!;

    public int Age { get; set; }

    public string? Password { get; set; }
    public string NickName { get; set; }
    public string Profile { get; set; }

    public bool AutoGeneratePassword { get; set; }
}