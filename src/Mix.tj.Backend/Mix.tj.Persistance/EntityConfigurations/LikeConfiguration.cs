using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mix.tj.Domain.Entities.Infrastructure;

namespace Mix.tj.Persistance.EntityConfigurations;

public class LikeConfiguration : IEntityTypeConfiguration<Like>
{
    public void Configure(EntityTypeBuilder<Like> builder)
    {
        builder.HasOne(b => b.User)
            .WithMany()
            .HasForeignKey(b => b.UserId);

        builder.HasOne(b => b.News)
            .WithMany(n => n.Likes)
            .HasForeignKey(b => b.NewsId);
    }
}
