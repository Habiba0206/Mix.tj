using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mix.tj.Domain.Entities.Infrastructure;

namespace Mix.tj.Persistance.EntityConfigurations;

public class NewsConfiguration : IEntityTypeConfiguration<News>
{
    public void Configure(EntityTypeBuilder<News> builder)
    {
        builder
            .Property(n => n.Headline)
            .IsRequired();

        builder
            .Property(n => n.Content)
            .IsRequired();
        
        builder
            .Property(n => n.Category)
            .IsRequired();

        builder.HasOne(b => b.User)
            .WithMany()
            .HasForeignKey(b => b.UserId);
    }
}
