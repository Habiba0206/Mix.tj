using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mix.tj.Domain.Entities.Identity;
using Mix.tj.Domain.Enums;

namespace Mix.tj.Persistance.EntityConfigurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder
            .HasIndex(user => user.Id)
            .IsUnique();

        builder
            .HasIndex(user => user.NickName)
            .IsUnique();

        builder
            .HasIndex(user => user.EmailAddress)
            .IsUnique();

        builder
            .Property(user => user.FirstName)
            .HasMaxLength(64)
            .IsRequired();

        builder
            .Property(user => user.LastName)
            .HasMaxLength(64)
            .IsRequired();
        builder
            .Property(user => user.EmailAddress)
            .HasMaxLength(128)
            .IsRequired();

        builder
            .Property(user => user.PasswordHash)
            .HasMaxLength(256)
            .IsRequired();

        builder
            .Property(user => user.NickName)
            .HasMaxLength(30)
            .IsRequired();

        builder
            .Property(user => user.Profile)
            .HasMaxLength(500)
            .IsRequired();

        builder
            .Property(user => user.Role)
            .HasConversion<string>()
            .HasDefaultValue(Role.User)
            .HasMaxLength(64)
            .IsRequired();
    }
}
