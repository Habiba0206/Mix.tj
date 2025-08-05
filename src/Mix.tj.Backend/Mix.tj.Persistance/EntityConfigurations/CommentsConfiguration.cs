using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mix.tj.Domain.Entities.Infrastructure;

namespace Mix.tj.Persistance.EntityConfigurations;

public class CommentsConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder
            .Property(c => c.Text)
            .HasMaxLength(5000)
            .IsRequired();

        builder
            .Property(c => c.Reply)
            .HasMaxLength(1000)
            .IsRequired();

        builder.HasOne(b => b.User)
            .WithMany()
            .HasForeignKey(b => b.UserId);
    }
}
