using Mix.tj.Domain.Enums;

namespace Mix.tj.Domain.Entities.Verification;

public class UserInfoVerificationCode : VerificationCode
{
    public UserInfoVerificationCode()
    {
        Type = VerificationType.UserInfoVerificationCode;
    }

    public Guid UserId { get; set; }
}